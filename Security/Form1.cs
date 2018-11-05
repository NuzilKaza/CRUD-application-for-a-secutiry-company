using Security.TablesInformation;
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
        private DataTable crewsDataTable;
        private DataTable departuresDataTable;
        private DataTable contractsDataTable;

        public mainForm()
        {
            InitializeComponent();
            this.connection = new SqlConnection(Properties.Settings.Default.connectionString);
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
            crewsDataTable = CreateDataSource("Crews_Select_All", CommandType.StoredProcedure);
            departuresDataTable = CreateDataSource("Departures_Select_All", CommandType.StoredProcedure);
            contractsDataTable = CreateDataSource("Contracts_Select_All", CommandType.StoredProcedure);

            //TODO: разобраться с колонкой адресов
            crewsDataGridView.DataSource = crewsDataTable;
            departuresDataGridView.DataSource = departuresDataTable;
            contractsDataGridView.DataSource = contractsDataTable;
        }

        private DataTable CreateDataSource(string commandText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = commandType;
            command.CommandText = commandText;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string columnName = reader.GetName(i);
                Type columnType = reader.GetFieldType(i);
                DataColumn dataColumn = new DataColumn(columnName, columnType);
                dataTable.Columns.Add(dataColumn);
            }

            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader.GetValue(i);
                }
                dataTable.Rows.Add(row);
            }

            connection.Close();
            return dataTable;
        }

        private void ShowRowsCountEverywhere()
        {
            ShowRowsCount(contractsDataGridView, contractsCountLabel);
            ShowRowsCount(departuresDataGridView, departuresCountLabel);
            ShowRowsCount(crewsDataGridView, crewsCountLabel);
        }

        private void ShowRowsCount(DataGridView dataGridView, Label labelWithCount)
        {
            labelWithCount.Text += " " + dataGridView.RowCount;
        }

        private bool CheckCrewId(int id)
        {
            for (int i = 0; i < crewsDataTable.Rows.Count; i++)
            {
                DataRow row = crewsDataTable.Rows[i];
                if ((int)row["crew_id"] == id) return false;
            }
            return true;
        }

        private int GetMaxId(DataTable dataTable, string columnName)
        {
            DataRow row = dataTable.Rows[dataTable.Rows.Count - 1];
            return Convert.ToInt32(row[columnName]);
        }

        private void addCrewButton_Click(object sender, EventArgs e)
        {
            int maxId = GetMaxId(crewsDataTable, "crew_id");
            CrewForm crewForm = new CrewForm(((DataTable)crewsDataGridView.DataSource).NewRow(), false, maxId);
            if (crewForm.ShowDialog() == DialogResult.OK)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "Crew_Insert";

                command.Parameters.Add(new SqlParameter("@crew_id", SqlDbType.Int));
                command.Parameters["@crew_id"].Value = crewForm.Row["crew_id"];
                command.Parameters.Add(new SqlParameter("@crew_leader", SqlDbType.NChar));
                command.Parameters["@crew_leader"].Value = crewForm.Row["crew_leader"];
                command.Parameters.Add(new SqlParameter("@crew_car_model", SqlDbType.NChar));
                command.Parameters["@crew_car_model"].Value = crewForm.Row["crew_car_model"];

                connection.Open();
                if (command.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Вставка выполнена успешно");
                }
                connection.Close();

                FillTables();
                ShowRowsCountEverywhere();
            }
        }
    }
}
