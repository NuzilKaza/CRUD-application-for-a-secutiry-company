using Security.Controllers;
using Security.Entities;
using System;
using System.Windows.Forms;

namespace Security
{
    public partial class DepartureForm : Form
    {
        private bool forUpdate;
        private DepartureController departureController;
        private CrewController crewController;
        private ContractController contractController;
        private Departure selectedDeparture;

        public DepartureForm(DepartureController departureController, CrewController crewController, ContractController contractController, bool forUpdate)
        {
            InitializeComponent();
            this.departureController = departureController;
            this.crewController = crewController;
            this.contractController = contractController;
            this.forUpdate = forUpdate;
        }

        public DepartureForm(DepartureController departureController, CrewController crewController, ContractController contractController, bool forUpdate, Departure selectedDeparture)
        {
            InitializeComponent();
            this.departureController = departureController;
            this.crewController = crewController;
            this.contractController = contractController;
            this.forUpdate = forUpdate;
            this.selectedDeparture = selectedDeparture;
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
            crewIdNumericUpDown.Value = selectedDeparture.CrewId;
            contractIdNumericUpDown.Value = selectedDeparture.ContractId;
            departureDateTimePicker.Value = selectedDeparture.Date;
            falseCallCheckBox.Checked = selectedDeparture.IsFalse;
            if (!selectedDeparture.IsFalse)
            {
                documentTextBox.Text = selectedDeparture.ArrestDocument;
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
                int departureId = departureController.GetMaxId() + 1;
                int crewId = (int)crewIdNumericUpDown.Value;
                int contractId = (int)contractIdNumericUpDown.Value;
                DateTime date = departureDateTimePicker.Value;
                bool falseCall = falseCallCheckBox.Checked;
                Departure departure = new Departure(departureId, crewId, contractId, date, falseCall);
                if (!falseCallCheckBox.Checked)
                {
                    departure.ArrestDocument = documentTextBox.Text;
                }

                departureController.Insert(departure);
            } else
            {
                selectedDeparture.CrewId = (int)crewIdNumericUpDown.Value;
                selectedDeparture.ContractId = (int)contractIdNumericUpDown.Value;
                selectedDeparture.Date = departureDateTimePicker.Value;
                selectedDeparture.IsFalse = falseCallCheckBox.Checked;
                if (!falseCallCheckBox.Checked)
                {
                    selectedDeparture.ArrestDocument = documentTextBox.Text;
                }

                departureController.Update(selectedDeparture);
            }
        }
    }
}
