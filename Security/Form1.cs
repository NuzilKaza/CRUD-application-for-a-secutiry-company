using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class mainForm : Form
    {
        private SqlConnection connection;
        private DataController dataController;
        private DataTable crewsDataTable;
        private DataTable departuresDataTable;
        private DataTable contractsDataTable;

        public mainForm()
        {
            InitializeComponent();
            this.connection = new SqlConnection(Properties.Settings.Default.connectionString);
            this.dataController = new DataController(this.connection);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //this.departuresTableAdapter.Fill(this.securityDataSet.Departures);
            //this.crewsTableAdapter.Fill(this.securityDataSet.Crews);
            //this.contracts_viewTableAdapter.Fill(this.securityDataSet.contracts_view);
            FillTables();
            ShowRowsCountEverywhere();
        }

        private void FillTables()
        {
            crewsDataTable = dataController.CreateDataSource("Crews_Select_All", CommandType.StoredProcedure);
            departuresDataTable = dataController.CreateDataSource("Departures_Select_All", CommandType.StoredProcedure);
            contractsDataTable = dataController.CreateDataSource("Contracts_Select_All", CommandType.StoredProcedure);

            //TODO: разобраться с таблицей адресов
            crewsDataGridView.DataSource = crewsDataTable;
            departuresDataGridView.DataSource = departuresDataTable;
            contractsDataGridView.DataSource = contractsDataTable;
        }

        private void ShowRowsCountEverywhere()
        {
            ShowRowsCount(contractsDataGridView, contractsCountLabel);
            ShowRowsCount(departuresDataGridView, departuresCountLabel);
            ShowRowsCount(crewsDataGridView, crewsCountLabel);
        }

        private void ShowRowsCount(DataGridView dataGridView, Label labelWithCount)
        {
            labelWithCount.Text = "Найдено " + dataGridView.RowCount;
        }

        private void addCrewButton_Click(object sender, EventArgs e)
        {
            int maxId = dataController.GetMaxId(crewsDataTable, "crew_id");
            CrewForm crewForm = new CrewForm(((DataTable)crewsDataGridView.DataSource).NewRow(), false, maxId);
            if (crewForm.ShowDialog() == DialogResult.OK)
            {
                DataRow crewRow = crewForm.Row;
                string[] paramNames = { "@crew_id", "@crew_leader", "@crew_car_model" };
                SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.NChar, SqlDbType.NChar };
                object[] paramValues = { crewRow["crew_id"], crewRow["crew_leader"], crewRow["crew_car_model"] };

                int result = dataController.ModifyData("Crew_Insert", CommandType.StoredProcedure, paramNames, paramTypes, paramValues);
                if (result == 0)
                {
                    MessageBox.Show("Ошибка выполнения вставки");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void addDepartureButton_Click(object sender, EventArgs e)
        {
            int maxDepartureId = dataController.GetMaxId(departuresDataTable, "departure_id");
            int maxCrewId = dataController.GetMaxId(crewsDataTable, "crew_id");
            int maxContractId = dataController.GetMaxId(contractsDataTable, "contract_id");

            DepartureForm departureForm = new DepartureForm(((DataTable)departuresDataGridView.DataSource).NewRow(), false, maxDepartureId, maxCrewId, maxContractId);
            if (departureForm.ShowDialog() == DialogResult.OK)
            {
                DataRow departureRow = departureForm.Row;
                string[] paramNames = { "@departure_id", "@crew_id", "@contract_id", "@departure_date_time", "@false_call" };
                SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Bit };
                object[] paramValues = { departureRow["departure_id"], departureRow["crew_id"], departureRow["contract_id"], departureRow["departure_date_time"], departureRow["false_call"] };
                int departureResult = dataController.ModifyData("Departure_Insert", CommandType.StoredProcedure, paramNames, paramTypes, paramValues);

                int falseCallResult;
                if (Convert.ToBoolean(departureRow["false_call"]))
                {
                    string[] paramNamesFalseCall = { "@departure_id" };
                    SqlDbType[] paramTypesFalseCall = { SqlDbType.Int };
                    object[] paramValuesFalseCall = { departureRow["departure_id"] };
                    falseCallResult = dataController.ModifyData("False_Departure_Insert", CommandType.StoredProcedure, paramNamesFalseCall, paramTypesFalseCall, paramValuesFalseCall);
                } else
                {
                    string[] paramNamesTrueCall = { "@departure_id", "@arrest_document" };
                    SqlDbType[] paramTypesTrueCall = { SqlDbType.Int, SqlDbType.NChar };
                    object[] paramValuesTrueCall = { departureRow["departure_id"], departureRow["arrest_document"] };
                    falseCallResult = dataController.ModifyData("True_Departure_Insert", CommandType.StoredProcedure, paramNamesTrueCall, paramTypesTrueCall, paramValuesTrueCall);
                }

                if (departureResult == 0 || falseCallResult == 0)
                {
                    MessageBox.Show("Ошибка выполнения вставки");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }
    }
}
