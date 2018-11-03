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

        public mainForm()
        {
            InitializeComponent();
            this.connection = new SqlConnection(Properties.Settings.Default.connectionString);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
            crewsDataGridView.DataSource = CreateDataSource("Crews_Select_All", CommandType.StoredProcedure);
            departuresDataGridView.DataSource = CreateDataSource("Departures_Select_All", CommandType.StoredProcedure);
            
            //this.departuresTableAdapter.Fill(this.securityDataSet.Departures);
            
            //this.crewsTableAdapter.Fill(this.securityDataSet.Crews);
            
            this.contracts_viewTableAdapter.Fill(this.securityDataSet.contracts_view);

            ShowRowsCountEverywhere();
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
    }
}
