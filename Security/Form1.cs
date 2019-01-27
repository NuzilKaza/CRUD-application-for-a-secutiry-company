using Security.Controllers;
using Security.Entities;
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

        private CrewController crewController;
        private DepartureController departureController;
        private ContractController contractController;

        public mainForm()
        {
            InitializeComponent();
            this.connection = new SqlConnection(Properties.Settings.Default.connectionString);
            this.dataController = new DataController(this.connection);

            this.crewController = new CrewController(dataController);
            this.departureController = new DepartureController(dataController);
            this.contractController = new ContractController(dataController);
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
            crewsDataGridView.DataSource = crewController.GetAllCrews();
            departuresDataGridView.DataSource = departureController.GetAllDepartures();
            contractsDataGridView.DataSource = contractController.GetAllContracts();
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
            CrewForm crewForm = new CrewForm(crewController, false);
            if (crewForm.ShowDialog() == DialogResult.OK)
            {
                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void addDepartureButton_Click(object sender, EventArgs e)
        {
            DepartureForm departureForm = new DepartureForm(departureController, crewController, contractController, false);
            if (departureForm.ShowDialog() == DialogResult.OK)
            {
                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void deleteCrewButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = crewsDataGridView.SelectedRows[0];
            int crewId = (int)selectedRow.Cells["crewidDataGridViewTextBoxColumn"].Value;

            DialogResult dialogResult = MessageBox.Show("Удалить выбранный экипаж?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                crewController.Delete(crewId);
                FillTables();
                ShowRowsCountEverywhere();
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
            Crew crew = crewController.Select(crewId);

            CrewForm crewForm = new CrewForm(crewController, true, crew);
            if (crewForm.ShowDialog() == DialogResult.OK)
            {
                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void editDepartureButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = departuresDataGridView.SelectedRows[0];
            int departureId = (int)selectedRow.Cells["departureidDataGridViewTextBoxColumn"].Value;
            Departure departure = departureController.Select(departureId);

            DepartureForm departureForm = new DepartureForm(departureController, crewController, contractController, true, departure);
            if (departureForm.ShowDialog() == DialogResult.OK)
            {
                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void editContractButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = contractsDataGridView.SelectedRows[0];
            int contractId = (int)selectedRow.Cells["contractidDataGridViewTextBoxColumn1"].Value;
            DataRow[] rows = contractsDataTable.Select(String.Format("contract_id = {0}", contractId));

            int maxContractId = dataController.GetMaxId(contractsDataTable, "contract_id");
            int maxClientId = dataController.GetMaxId(contractsDataTable, "client_id");
            int maxHouseId = dataController.GetMaxId(contractsDataTable, "house_id");
            int maxApartmentId = dataController.GetMaxId(contractsDataTable, "apartment_id");

            ContractForm contractForm = new ContractForm(rows[0], true, maxContractId, maxClientId, maxHouseId, maxApartmentId);
            if (contractForm.ShowDialog() == DialogResult.OK)
            {
                ContractController contractController = new ContractController(contractForm.Row);
                int result = contractController.Update();
                if (result == 0)
                {
                    MessageBox.Show("Ошибка выполнения редактирования");
                } else
                {
                    MessageBox.Show("Изменения сохранены");
                }

                FillTables();
                ShowRowsCountEverywhere();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            SelectContracts();
        }

        private void contractAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            SelectContracts();
        }

        private void SelectContracts()
        {
            string name = nameTextBox.Text;
            string address = contractAddressTextBox.Text;

            DataTable dataTable = contractController.SelectContracts(name, address);
            contractsDataGridView.DataSource = dataTable;
            ShowRowsCount(contractsDataGridView, contractsCountLabel);
        }


        private void startDepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SelectDepartures();
        }

        private void finishDepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SelectDepartures();
        }

        private void SelectDepartures()
        {
            DateTime startDate = startDepartureDateTimePicker.Value;
            DateTime finishDate = finishDepartureDateTimePicker.Value;

            DataTable dataTable = departureController.SelectDepartures(startDate, finishDate); ;
            departuresDataGridView.DataSource = dataTable;
            ShowRowsCount(departuresDataGridView, departuresCountLabel);
        }
    }
}
