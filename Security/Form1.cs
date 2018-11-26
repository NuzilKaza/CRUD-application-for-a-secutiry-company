using Security.Entity;
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
            CrewForm crewForm = new CrewForm(crewsDataTable.NewRow(), false, maxId);
            if (crewForm.ShowDialog() == DialogResult.OK)
            {
                CrewController crewController = new CrewController(crewForm.Row);
                int result = crewController.Insert();
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

            DepartureForm departureForm = new DepartureForm(departuresDataTable.NewRow(), false, maxDepartureId, maxCrewId, maxContractId);
            if (departureForm.ShowDialog() == DialogResult.OK)
            {
                DepartureController departureController = new DepartureController(departureForm.Row);
                int result = departureController.Insert();

                if (result == 0)
                {
                    MessageBox.Show("Ошибка выполнения вставки");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void deleteCrewButton_Click(object sender, EventArgs e)
        {
            if (crewsDataGridView.SelectedRows.Count == 0)
            {
                crewWarningLabel.Visible = true;
            } else
            {
                crewWarningLabel.Visible = false;
                DataGridViewRow selectedRow = crewsDataGridView.SelectedRows[0];
                int crewId = (int)selectedRow.Cells["crewidDataGridViewTextBoxColumn"].Value;

                DialogResult dialogResult = MessageBox.Show("Удалить выбранный экипаж?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CrewController crewController = new CrewController(crewId);
                    int result = crewController.Delete();
                    if (result == 0)
                    {
                        MessageBox.Show("Ошибка выполнения удаления");
                    }

                    FillTables();
                    ShowRowsCountEverywhere();
                }
            }
        }

        private void addContractButton_Click(object sender, EventArgs e)
        {
            int maxContractId = dataController.GetMaxId(contractsDataTable, "contract_id");
            int maxClientId = dataController.GetMaxId(contractsDataTable, "client_id");
            int maxHouseId = dataController.GetMaxId(contractsDataTable, "house_id");
            int maxApartmentId = dataController.GetMaxId(contractsDataTable, "apartment_id");

            ContractForm contractForm = new ContractForm(contractsDataTable.NewRow(), false, maxContractId, maxClientId, maxHouseId, maxApartmentId);
            if (contractForm.ShowDialog() == DialogResult.OK)
            {
                ContractController contractController = new ContractController(contractForm.Row);
                int result = contractController.Insert(maxClientId, maxHouseId, maxApartmentId);

                if (result == 0)
                {
                    MessageBox.Show("Ошибка выполнения вставки");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void editCrewButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = crewsDataGridView.SelectedRows[0];
            int crewId = (int)selectedRow.Cells["crewidDataGridViewTextBoxColumn"].Value;
            DataRow[] rows = crewsDataTable.Select(String.Format("crew_id = {0}", crewId));

            int maxId = dataController.GetMaxId(crewsDataTable, "crew_id");
            CrewForm crewForm = new CrewForm(rows[0], true, maxId);
            if (crewForm.ShowDialog() == DialogResult.OK)
            {
                CrewController crewController = new CrewController(crewForm.Row);
                int result = crewController.Update();
                if (result == 0)
                {
                    MessageBox.Show("Ошибка выполнения редактирования");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void editDepartureButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = departuresDataGridView.SelectedRows[0];
            int departureId = (int)selectedRow.Cells["departureidDataGridViewTextBoxColumn"].Value;
            DataRow[] rows = departuresDataTable.Select(String.Format("departure_id = {0}", departureId));

            int maxDepartureId = dataController.GetMaxId(departuresDataTable, "departure_id");
            int maxCrewId = dataController.GetMaxId(crewsDataTable, "crew_id");
            int maxContractId = dataController.GetMaxId(contractsDataTable, "contract_id");

            DepartureForm departureForm = new DepartureForm(rows[0], true, maxDepartureId, maxCrewId, maxContractId);
            if (departureForm.ShowDialog() == DialogResult.OK)
            {
                DepartureController departureController = new DepartureController(departureForm.Row);
                int result = departureController.Update();

                if (result == 0)
                {
                    MessageBox.Show("Ошибка выполнения редактирования");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }
    }
}
