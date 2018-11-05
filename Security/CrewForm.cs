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
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (leaderTextBox.Text != "" && carModelTextBox.Text != "")
            {
                warningLabel.Visible = false;
                row["crew_id"] = lastCrewId + 1;
                row["crew_leader"] = leaderTextBox.Text;
                row["crew_car_model"] = carModelTextBox.Text;
            } else
            {
                warningLabel.Visible = true;
                DialogResult = DialogResult.None;
            }
        }
    }
}
