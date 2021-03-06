﻿namespace Security
{
    partial class DepartureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.crewIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.contractIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.falseCallCheckBox = new System.Windows.Forms.CheckBox();
            this.documentLabel = new System.Windows.Forms.Label();
            this.documentTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crewIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер экипажа";
            // 
            // crewIdNumericUpDown
            // 
            this.crewIdNumericUpDown.Location = new System.Drawing.Point(133, 12);
            this.crewIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crewIdNumericUpDown.Name = "crewIdNumericUpDown";
            this.crewIdNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.crewIdNumericUpDown.TabIndex = 1;
            this.crewIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contractIdNumericUpDown
            // 
            this.contractIdNumericUpDown.Location = new System.Drawing.Point(133, 40);
            this.contractIdNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.contractIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.contractIdNumericUpDown.Name = "contractIdNumericUpDown";
            this.contractIdNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.contractIdNumericUpDown.TabIndex = 2;
            this.contractIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер договора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата выезда";
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.Location = new System.Drawing.Point(133, 68);
            this.departureDateTimePicker.MaxDate = new System.DateTime(2210, 12, 31, 0, 0, 0, 0);
            this.departureDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(199, 22);
            this.departureDateTimePicker.TabIndex = 3;
            // 
            // falseCallCheckBox
            // 
            this.falseCallCheckBox.AutoSize = true;
            this.falseCallCheckBox.Location = new System.Drawing.Point(15, 106);
            this.falseCallCheckBox.Name = "falseCallCheckBox";
            this.falseCallCheckBox.Size = new System.Drawing.Size(126, 21);
            this.falseCallCheckBox.TabIndex = 4;
            this.falseCallCheckBox.Text = "Ложный вызов";
            this.falseCallCheckBox.UseVisualStyleBackColor = true;
            this.falseCallCheckBox.CheckedChanged += new System.EventHandler(this.falseCallCheckBox_CheckedChanged);
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Location = new System.Drawing.Point(12, 139);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(287, 17);
            this.documentLabel.TabIndex = 7;
            this.documentLabel.Text = "Документ, оформленный при задержании";
            // 
            // documentTextBox
            // 
            this.documentTextBox.Location = new System.Drawing.Point(15, 159);
            this.documentTextBox.MaxLength = 40;
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(317, 22);
            this.documentTextBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(176, 197);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(257, 197);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 27);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.Crimson;
            this.warningLabel.Location = new System.Drawing.Point(12, 202);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(160, 17);
            this.warningLabel.TabIndex = 11;
            this.warningLabel.Text = "Заполните все поля";
            this.warningLabel.Visible = false;
            // 
            // DepartureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 233);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.documentTextBox);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.falseCallCheckBox);
            this.Controls.Add(this.departureDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractIdNumericUpDown);
            this.Controls.Add(this.crewIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartureForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выезд";
            this.Load += new System.EventHandler(this.DepartureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crewIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown crewIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown contractIdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.CheckBox falseCallCheckBox;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.TextBox documentTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label warningLabel;
    }
}