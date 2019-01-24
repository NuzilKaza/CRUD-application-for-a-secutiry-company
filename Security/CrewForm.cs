using Security.Controllers;
using Security.Entities;
using System;
using System.Windows.Forms;

namespace Security
{
    public partial class CrewForm : Form
    {
        private bool forUpdate;
        private CrewController crewController;
        private Crew selectedCrew;

        public CrewForm(CrewController crewController, bool forUpdate)
        {
            InitializeComponent();
            this.forUpdate = forUpdate;
            this.crewController = crewController;
        }

        public CrewForm(CrewController crewController, bool forUpdate, Crew selectedCrew)
        {
            InitializeComponent();
            this.forUpdate = forUpdate;
            this.crewController = crewController;
            this.selectedCrew = selectedCrew;
        }

        private void CrewForm_Load(object sender, EventArgs e)
        {
            if (forUpdate)
            {
                FillForm();
            }
        }

        private void FillForm()
        {
            leaderTextBox.Text = selectedCrew.LeaderName;
            carModelTextBox.Text = selectedCrew.CarModel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!TextBoxesAreEmpty())
            {
                warningLabel.Visible = false;
                CollectInformation();
            } else
            {
                warningLabel.Visible = true;
                DialogResult = DialogResult.None;
            }
        }

        private bool TextBoxesAreEmpty()
        {
            return leaderTextBox.Text == "" || carModelTextBox.Text == "";
        }

        private void CollectInformation()
        {
            if (!forUpdate)
            {
                int crewId = crewController.GetMaxId() + 1;
                Crew crew = new Crew(crewId, leaderTextBox.Text, carModelTextBox.Text);
                crewController.Insert(crew);
            } else
            {
                selectedCrew.LeaderName = leaderTextBox.Text;
                selectedCrew.CarModel = carModelTextBox.Text;
                crewController.Update(selectedCrew);
            }
        }
    }
}
