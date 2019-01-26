using Security.Controllers;
using Security.Entities;
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

        private DepartureController departureController;
        private CrewController crewController;
        private ContractController contractController;

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

        public DepartureForm(DepartureController departureController, CrewController crewController, ContractController contractController, bool forUpdate)
        {
            InitializeComponent();
            this.departureController = departureController;
            this.crewController = crewController;
            this.contractController = contractController;
            this.forUpdate = forUpdate;
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
            if (forUpdate)
            {
                FillForm();
            }
            crewIdNumericUpDown.Maximum = crewController.GetMaxId();
            contractIdNumericUpDown.Maximum = contractController.GetMaxId();
        }

        private void FillForm()
        {
            crewIdNumericUpDown.Value = (int)row["crew_id"];
            contractIdNumericUpDown.Value = (int)row["contract_id"];
            departureDateTimePicker.Value = Convert.ToDateTime(row["departure_date_time"]);
            falseCallCheckBox.Checked = Convert.ToBoolean(row["false_call"]);
            if (!Convert.ToBoolean(row["false_call"]))
            {
                documentTextBox.Text = row["arrest_document"].ToString();
            }
        }

        private void falseCallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            documentLabel.Enabled = !documentLabel.Enabled;
            documentTextBox.Enabled = !documentTextBox.Enabled;
        }

        private void CollectInformation()
        {
            if (!forUpdate)
            {
                lastDepartureId = departureController.GetMaxId();
                
            }
            
            int crewId = (int)crewIdNumericUpDown.Value;
            int contractId = (int)contractIdNumericUpDown.Value;
            DateTime date = departureDateTimePicker.Value;
            bool falseCall = falseCallCheckBox.Checked;
            Departure departure = new Departure(lastDepartureId + 1, crewId, contractId, date, falseCall);

            if (!falseCallCheckBox.Checked)
            {
                departure.ArrestDocument = documentTextBox.Text;
            }

            departureController.Insert(departure);
        }
    }
}
