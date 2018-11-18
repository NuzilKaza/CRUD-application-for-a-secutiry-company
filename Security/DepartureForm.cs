using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class DepartureForm : Form
    {
        private DataRow row;
        private bool forUpdate;
        private int lastCrewId;
        private int lastDepartureId;
        private int lastContractId;

        public DataRow Row { get => row; set => row = value; }

        public DepartureForm(DataRow row, bool forUpdate, int lastDepartureId, int lastCrewId, int lastContractId)
        {
            InitializeComponent();
            this.row = row;
            this.forUpdate = forUpdate;
            this.lastCrewId = lastCrewId;
            this.lastDepartureId = lastDepartureId;
            this.lastContractId = lastContractId;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!DocumentTextBoxIsEmpty())
            {
                warningLabel.Visible = false;
                CollectInformation();
            }
            else
            {
                warningLabel.Visible = true;
                DialogResult = DialogResult.None;
            }
        }

        private bool DocumentTextBoxIsEmpty()
        {
            return !falseCallCheckBox.Checked && documentTextBox.Text == "";
;        }

        private void DepartureForm_Load(object sender, EventArgs e)
        {
            crewIdNumericUpDown.Maximum = lastCrewId;
            contractIdNumericUpDown.Maximum = lastContractId;
        }

        private void falseCallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            documentLabel.Enabled = !documentLabel.Enabled;
            documentTextBox.Enabled = !documentTextBox.Enabled;
        }

        private void CollectInformation()
        {
            row["departure_id"] = lastDepartureId + 1;
            row["crew_id"] = (int)crewIdNumericUpDown.Value;
            row["contract_id"] = (int)contractIdNumericUpDown.Value;
            row["departure_date_time"] = departureDateTimePicker.Value;
            row["false_call"] = falseCallCheckBox.Checked;
            if (!falseCallCheckBox.Checked)
            {
                row["arrest_document"] = documentTextBox.Text;
            }
        }
    }
}
