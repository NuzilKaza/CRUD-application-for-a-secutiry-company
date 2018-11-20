using Security.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class ContractForm : Form
    {
        private DataRow row;
        private bool forUpdate;
        private int lastContractId;
        private int lastClientId;
        private int lastHouseId;
        private int lastApartmentId;
        private const int USUAL_CONTRACT_TIME = 4; //в годах

        public DataRow Row { get => row; set => row = value; }

        public ContractForm(DataRow row, bool forUpdate, int lastContractId, int lastClientId, int lastHouseId, int lastApartmentId)
        {
            InitializeComponent();
            this.row = row;
            this.forUpdate = forUpdate;
            this.lastContractId = lastContractId;
            this.lastClientId= lastClientId;
            this.lastHouseId = lastHouseId;
            this.lastApartmentId = lastApartmentId;
        }

        private void balconyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            balconyTypeLabel.Enabled = !balconyTypeLabel.Enabled;
            balconyTypeComboBox.Enabled = !balconyTypeComboBox.Enabled;
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            SetDateTimePickers();
            if (!forUpdate)
            {
                DisableExtensionDateTimePicker();
            }
        }

        private void SetDateTimePickers()
        {
            DateTime commencementDate = commencementDateTimePicker.Value;
            DateTime expirationDate = commencementDate.AddYears(USUAL_CONTRACT_TIME);
            expirationDateTimePicker.Value = expirationDate;

            DateTime extensionDate = expirationDate.AddDays(1);
            extensionDateTimePicker.Value = extensionDate;
        }

        private void DisableExtensionDateTimePicker()
        {
            extensionLabel.Enabled = false;
            extensionDateTimePicker.Enabled = false;
        }

        private bool TextBoxesAreEmpty()
        {
            return nameTextBox.Text == "" || 
                !phoneMaskedTextBox.MaskFull || 
                clientAdressTextBox.Text == "" ||
                apartmentAddressTextBox.Text == "";
        }

        private bool ComboBoxesAreEmpty()
        {
            return houseTypeComboBox.SelectedItem == null ||
                doorTypeComboBox.SelectedItem == null ||
                (balconyCheckBox.Checked && balconyTypeComboBox.SelectedItem == null);
        }

        private bool DatesAreCorrect()
        {
            return commencementDateTimePicker.Value < expirationDateTimePicker.Value &&
                expirationDateTimePicker.Value < extensionDateTimePicker.Value;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (TextBoxesAreEmpty() || ComboBoxesAreEmpty())
            {
                warningLabel.Text = "Заполните все поля";
                DialogResult = DialogResult.None;
            } else if (!DatesAreCorrect())
            {
                warningLabel.Text = "Исправьте даты";
                DialogResult = DialogResult.None;
            } else
            {
                warningLabel.Text = "";
                CollectInformation();
            }
        }

        private void CollectInformation()
        {
            row["contract_id"] = lastContractId + 1;
            row["client_name"] = nameTextBox.Text;
            row["client_address"] = clientAdressTextBox.Text;
            row["client_phone"] = phoneMaskedTextBox.Text;

            row["apartment_address_in_contract"] = apartmentAddressTextBox.Text;
            row["house_type"] = houseTypeComboBox.SelectedItem;
            row["floors_count"] = floorsCountNumericUpDown.Value;
            row["apartment_floor"] = apartmentFloorNumericUpDown.Value;
            row["apartment_door_type"] = doorTypeComboBox.SelectedItem;
            row["balcony"] = balconyCheckBox.Checked;
            if (balconyCheckBox.Checked)
            {
                row["balcony_type"] = balconyTypeComboBox.SelectedItem;
            }
            row["code_key"] = codeKeyCheckBox.Checked;

            row["commencement_date"] = commencementDateTimePicker.Value;
            row["expiration_date"] = expirationDateTimePicker.Value;
            row["payment_per_month"] = paymentNumericUpDown.Value;
            row["compensation"] = compensationNumericUpDown.Value;
            row["fine"] = fineNumericUpDown.Value;

            if (additionalRichTextBox.Text != "")
            {
                row["additional_conditions"] = additionalRichTextBox.Text;
            }

            /*ClientController clientController = new ClientController(row);
            row["client_id"] = clientController.GetClientId(lastClientId);

            HouseController houseController = new HouseController(row);
            row["house_id"] = houseController.GetHouseId(lastHouseId);

            ApartmentController apartmentController = new ApartmentController(row);
            row["apartment_id"] = apartmentController.GetApartmentId(Convert.ToInt32(row["house_id"]), lastApartmentId);*/

        }

        private void floorsCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            apartmentFloorNumericUpDown.Maximum = floorsCountNumericUpDown.Value;
        }
    }
}
