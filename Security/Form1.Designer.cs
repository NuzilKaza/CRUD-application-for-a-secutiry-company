﻿namespace Security
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshContractsButton = new System.Windows.Forms.Button();
            this.editContractButton = new System.Windows.Forms.Button();
            this.addContractButton = new System.Windows.Forms.Button();
            this.contractsCountLabel = new System.Windows.Forms.Label();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.contractAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departuresCountLabel = new System.Windows.Forms.Label();
            this.refreshDeparturesButton = new System.Windows.Forms.Button();
            this.departuresDataGridView = new System.Windows.Forms.DataGridView();
            this.editDepartureButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addDepartureButton = new System.Windows.Forms.Button();
            this.crewIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.finishDepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.startDepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureAdressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crewsCountLabel = new System.Windows.Forms.Label();
            this.deleteCrewButton = new System.Windows.Forms.Button();
            this.refreshCrewsButton = new System.Windows.Forms.Button();
            this.editCrewButton = new System.Windows.Forms.Button();
            this.addCrewButton = new System.Windows.Forms.Button();
            this.crewsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departuresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewIdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 799);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refreshContractsButton);
            this.tabPage1.Controls.Add(this.editContractButton);
            this.tabPage1.Controls.Add(this.addContractButton);
            this.tabPage1.Controls.Add(this.contractsCountLabel);
            this.tabPage1.Controls.Add(this.contractsDataGridView);
            this.tabPage1.Controls.Add(this.contractAddressTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 770);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Договоры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refreshContractsButton
            // 
            this.refreshContractsButton.Location = new System.Drawing.Point(774, 148);
            this.refreshContractsButton.Name = "refreshContractsButton";
            this.refreshContractsButton.Size = new System.Drawing.Size(136, 30);
            this.refreshContractsButton.TabIndex = 8;
            this.refreshContractsButton.Text = "Обновить";
            this.refreshContractsButton.UseVisualStyleBackColor = true;
            // 
            // editContractButton
            // 
            this.editContractButton.Location = new System.Drawing.Point(774, 112);
            this.editContractButton.Name = "editContractButton";
            this.editContractButton.Size = new System.Drawing.Size(136, 30);
            this.editContractButton.TabIndex = 7;
            this.editContractButton.Text = "Изменить";
            this.editContractButton.UseVisualStyleBackColor = true;
            // 
            // addContractButton
            // 
            this.addContractButton.Location = new System.Drawing.Point(774, 76);
            this.addContractButton.Name = "addContractButton";
            this.addContractButton.Size = new System.Drawing.Size(136, 30);
            this.addContractButton.TabIndex = 6;
            this.addContractButton.Text = "Добавить";
            this.addContractButton.UseVisualStyleBackColor = true;
            // 
            // contractsCountLabel
            // 
            this.contractsCountLabel.AutoSize = true;
            this.contractsCountLabel.Location = new System.Drawing.Point(6, 56);
            this.contractsCountLabel.Name = "contractsCountLabel";
            this.contractsCountLabel.Size = new System.Drawing.Size(66, 17);
            this.contractsCountLabel.TabIndex = 5;
            this.contractsCountLabel.Text = "Найдено";
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Location = new System.Drawing.Point(9, 76);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.RowTemplate.Height = 24;
            this.contractsDataGridView.Size = new System.Drawing.Size(745, 446);
            this.contractsDataGridView.TabIndex = 4;
            // 
            // contractAddressTextBox
            // 
            this.contractAddressTextBox.Location = new System.Drawing.Point(438, 25);
            this.contractAddressTextBox.MaxLength = 60;
            this.contractAddressTextBox.Name = "contractAddressTextBox";
            this.contractAddressTextBox.Size = new System.Drawing.Size(316, 22);
            this.contractAddressTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(54, 22);
            this.nameTextBox.MaxLength = 60;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(316, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 770);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выезды";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.departuresCountLabel);
            this.groupBox2.Controls.Add(this.refreshDeparturesButton);
            this.groupBox2.Controls.Add(this.departuresDataGridView);
            this.groupBox2.Controls.Add(this.editDepartureButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.addDepartureButton);
            this.groupBox2.Controls.Add(this.crewIdNumericUpDown);
            this.groupBox2.Controls.Add(this.finishDepartureDateTimePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.startDepartureDateTimePicker);
            this.groupBox2.Controls.Add(this.departureAdressTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выезды";
            // 
            // departuresCountLabel
            // 
            this.departuresCountLabel.AutoSize = true;
            this.departuresCountLabel.Location = new System.Drawing.Point(6, 102);
            this.departuresCountLabel.Name = "departuresCountLabel";
            this.departuresCountLabel.Size = new System.Drawing.Size(66, 17);
            this.departuresCountLabel.TabIndex = 14;
            this.departuresCountLabel.Text = "Найдено";
            // 
            // refreshDeparturesButton
            // 
            this.refreshDeparturesButton.Location = new System.Drawing.Point(792, 197);
            this.refreshDeparturesButton.Name = "refreshDeparturesButton";
            this.refreshDeparturesButton.Size = new System.Drawing.Size(136, 30);
            this.refreshDeparturesButton.TabIndex = 15;
            this.refreshDeparturesButton.Text = "Обновить";
            this.refreshDeparturesButton.UseVisualStyleBackColor = true;
            // 
            // departuresDataGridView
            // 
            this.departuresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departuresDataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.departuresDataGridView.Location = new System.Drawing.Point(6, 125);
            this.departuresDataGridView.Name = "departuresDataGridView";
            this.departuresDataGridView.RowTemplate.Height = 24;
            this.departuresDataGridView.Size = new System.Drawing.Size(780, 319);
            this.departuresDataGridView.TabIndex = 13;
            // 
            // editDepartureButton
            // 
            this.editDepartureButton.Location = new System.Drawing.Point(792, 161);
            this.editDepartureButton.Name = "editDepartureButton";
            this.editDepartureButton.Size = new System.Drawing.Size(136, 30);
            this.editDepartureButton.TabIndex = 14;
            this.editDepartureButton.Text = "Изменить";
            this.editDepartureButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер экипажа";
            // 
            // addDepartureButton
            // 
            this.addDepartureButton.Location = new System.Drawing.Point(792, 125);
            this.addDepartureButton.Name = "addDepartureButton";
            this.addDepartureButton.Size = new System.Drawing.Size(136, 30);
            this.addDepartureButton.TabIndex = 13;
            this.addDepartureButton.Text = "Добавить";
            this.addDepartureButton.UseVisualStyleBackColor = true;
            // 
            // crewIdNumericUpDown
            // 
            this.crewIdNumericUpDown.Location = new System.Drawing.Point(116, 33);
            this.crewIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crewIdNumericUpDown.Name = "crewIdNumericUpDown";
            this.crewIdNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.crewIdNumericUpDown.TabIndex = 11;
            this.crewIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // finishDepartureDateTimePicker
            // 
            this.finishDepartureDateTimePicker.Location = new System.Drawing.Point(341, 63);
            this.finishDepartureDateTimePicker.MaxDate = new System.DateTime(2210, 12, 31, 0, 0, 0, 0);
            this.finishDepartureDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.finishDepartureDateTimePicker.Name = "finishDepartureDateTimePicker";
            this.finishDepartureDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.finishDepartureDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата";
            // 
            // startDepartureDateTimePicker
            // 
            this.startDepartureDateTimePicker.Location = new System.Drawing.Point(56, 63);
            this.startDepartureDateTimePicker.MaxDate = new System.DateTime(2210, 12, 31, 0, 0, 0, 0);
            this.startDepartureDateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.startDepartureDateTimePicker.Name = "startDepartureDateTimePicker";
            this.startDepartureDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDepartureDateTimePicker.TabIndex = 8;
            // 
            // departureAdressTextBox
            // 
            this.departureAdressTextBox.Location = new System.Drawing.Point(225, 32);
            this.departureAdressTextBox.Name = "departureAdressTextBox";
            this.departureAdressTextBox.Size = new System.Drawing.Size(316, 22);
            this.departureAdressTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crewsCountLabel);
            this.groupBox1.Controls.Add(this.deleteCrewButton);
            this.groupBox1.Controls.Add(this.refreshCrewsButton);
            this.groupBox1.Controls.Add(this.editCrewButton);
            this.groupBox1.Controls.Add(this.addCrewButton);
            this.groupBox1.Controls.Add(this.crewsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(0, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Экипажи";
            // 
            // crewsCountLabel
            // 
            this.crewsCountLabel.AutoSize = true;
            this.crewsCountLabel.Location = new System.Drawing.Point(6, 25);
            this.crewsCountLabel.Name = "crewsCountLabel";
            this.crewsCountLabel.Size = new System.Drawing.Size(66, 17);
            this.crewsCountLabel.TabIndex = 13;
            this.crewsCountLabel.Text = "Найдено";
            // 
            // deleteCrewButton
            // 
            this.deleteCrewButton.Location = new System.Drawing.Point(528, 117);
            this.deleteCrewButton.Name = "deleteCrewButton";
            this.deleteCrewButton.Size = new System.Drawing.Size(136, 30);
            this.deleteCrewButton.TabIndex = 12;
            this.deleteCrewButton.Text = "Удалить";
            this.deleteCrewButton.UseVisualStyleBackColor = true;
            // 
            // refreshCrewsButton
            // 
            this.refreshCrewsButton.Location = new System.Drawing.Point(528, 153);
            this.refreshCrewsButton.Name = "refreshCrewsButton";
            this.refreshCrewsButton.Size = new System.Drawing.Size(136, 30);
            this.refreshCrewsButton.TabIndex = 11;
            this.refreshCrewsButton.Text = "Обновить";
            this.refreshCrewsButton.UseVisualStyleBackColor = true;
            // 
            // editCrewButton
            // 
            this.editCrewButton.Location = new System.Drawing.Point(528, 81);
            this.editCrewButton.Name = "editCrewButton";
            this.editCrewButton.Size = new System.Drawing.Size(136, 30);
            this.editCrewButton.TabIndex = 10;
            this.editCrewButton.Text = "Изменить";
            this.editCrewButton.UseVisualStyleBackColor = true;
            // 
            // addCrewButton
            // 
            this.addCrewButton.Location = new System.Drawing.Point(528, 45);
            this.addCrewButton.Name = "addCrewButton";
            this.addCrewButton.Size = new System.Drawing.Size(136, 30);
            this.addCrewButton.TabIndex = 9;
            this.addCrewButton.Text = "Добавить";
            this.addCrewButton.UseVisualStyleBackColor = true;
            // 
            // crewsDataGridView
            // 
            this.crewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewsDataGridView.Location = new System.Drawing.Point(6, 45);
            this.crewsDataGridView.Name = "crewsDataGridView";
            this.crewsDataGridView.RowTemplate.Height = 24;
            this.crewsDataGridView.Size = new System.Drawing.Size(516, 249);
            this.crewsDataGridView.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 823);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Охрана квартир";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departuresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewIdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox contractAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button refreshContractsButton;
        private System.Windows.Forms.Button editContractButton;
        private System.Windows.Forms.Button addContractButton;
        private System.Windows.Forms.Label contractsCountLabel;
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker startDepartureDateTimePicker;
        private System.Windows.Forms.TextBox departureAdressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteCrewButton;
        private System.Windows.Forms.Button refreshCrewsButton;
        private System.Windows.Forms.Button editCrewButton;
        private System.Windows.Forms.Button addCrewButton;
        private System.Windows.Forms.DataGridView crewsDataGridView;
        private System.Windows.Forms.DateTimePicker finishDepartureDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshDeparturesButton;
        private System.Windows.Forms.DataGridView departuresDataGridView;
        private System.Windows.Forms.Button editDepartureButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addDepartureButton;
        private System.Windows.Forms.NumericUpDown crewIdNumericUpDown;
        private System.Windows.Forms.Label departuresCountLabel;
        private System.Windows.Forms.Label crewsCountLabel;
    }
}
