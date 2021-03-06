﻿using System;
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
    public partial class CrewForm : Form
    {
        private DataRow row;
        private bool forUpdate;
        private int lastCrewId;

        public CrewForm(DataRow row, bool forUpdate, int lastCrewId)
        {
            InitializeComponent();
            this.row = row;
            this.forUpdate = forUpdate;
            this.lastCrewId = lastCrewId;
        }

        public DataRow Row { get => row; set => row = value; }

        private void CrewForm_Load(object sender, EventArgs e)
        {
            if (forUpdate)
            {
                FillForm();
            }
        }

        private void FillForm()
        {
            leaderTextBox.Text = row["crew_leader"].ToString();
            carModelTextBox.Text = row["crew_car_model"].ToString();
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
                row["crew_id"] = lastCrewId + 1; 
            }
            row["crew_leader"] = leaderTextBox.Text;
            row["crew_car_model"] = carModelTextBox.Text;
        }
    }
}
