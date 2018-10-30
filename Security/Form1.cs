using Security.TablesInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "securityDataSet.Departures". При необходимости она может быть перемещена или удалена.
            this.departuresTableAdapter.Fill(this.securityDataSet.Departures);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "securityDataSet.Crews". При необходимости она может быть перемещена или удалена.
            this.crewsTableAdapter.Fill(this.securityDataSet.Crews);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "securityDataSet.contracts_view". При необходимости она может быть перемещена или удалена.
            this.contracts_viewTableAdapter.Fill(this.securityDataSet.contracts_view);

            String[] crewColumnsNames = { "Номер экипажа", "Командир экипажа", "Марка автомобиля" };
            RenameColumns(crewsDataGridView, crewColumnsNames);

            String[] departuresColumnsNames = { "Номер выезда", "Номер экипажа", "Номер договора", "Дата и время выезда", "Ложный вызов" };
            RenameColumns(departuresDataGridView, departuresColumnsNames);
        }

        private void RenameColumns(DataGridView dataGridView, String[] columnsNames)
        {
            int columnIndex = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = columnsNames[columnIndex++];
            }
        }
    }
}
