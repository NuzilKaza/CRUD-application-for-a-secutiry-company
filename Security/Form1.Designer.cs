namespace Security
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshContractsButton1 = new System.Windows.Forms.Button();
            this.editContractButton = new System.Windows.Forms.Button();
            this.addContractButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.contractAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.finishDepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.startDepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureAdressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 738);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refreshContractsButton1);
            this.tabPage1.Controls.Add(this.editContractButton);
            this.tabPage1.Controls.Add(this.addContractButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.contractsDataGridView);
            this.tabPage1.Controls.Add(this.contractAddressTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Договоры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refreshContractsButton1
            // 
            this.refreshContractsButton1.Location = new System.Drawing.Point(774, 148);
            this.refreshContractsButton1.Name = "refreshContractsButton1";
            this.refreshContractsButton1.Size = new System.Drawing.Size(136, 30);
            this.refreshContractsButton1.TabIndex = 8;
            this.refreshContractsButton1.Text = "Обновить";
            this.refreshContractsButton1.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Найдено";
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
            this.tabPage2.Size = new System.Drawing.Size(974, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выезды";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.finishDepartureDateTimePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.startDepartureDateTimePicker);
            this.groupBox2.Controls.Add(this.departureAdressTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выезды";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 286);
            this.dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер бригады";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(795, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown1.TabIndex = 11;
            // 
            // finishDepartureDateTimePicker
            // 
            this.finishDepartureDateTimePicker.Location = new System.Drawing.Point(308, 61);
            this.finishDepartureDateTimePicker.Name = "finishDepartureDateTimePicker";
            this.finishDepartureDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.finishDepartureDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата";
            // 
            // startDepartureDateTimePicker
            // 
            this.startDepartureDateTimePicker.Location = new System.Drawing.Point(54, 61);
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
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteCrewButton);
            this.groupBox1.Controls.Add(this.refreshCrewsButton);
            this.groupBox1.Controls.Add(this.editCrewButton);
            this.groupBox1.Controls.Add(this.addCrewButton);
            this.groupBox1.Controls.Add(this.crewsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Экипажи";
            // 
            // deleteCrewButton
            // 
            this.deleteCrewButton.Location = new System.Drawing.Point(528, 104);
            this.deleteCrewButton.Name = "deleteCrewButton";
            this.deleteCrewButton.Size = new System.Drawing.Size(136, 30);
            this.deleteCrewButton.TabIndex = 12;
            this.deleteCrewButton.Text = "Удалить";
            this.deleteCrewButton.UseVisualStyleBackColor = true;
            // 
            // refreshCrewsButton
            // 
            this.refreshCrewsButton.Location = new System.Drawing.Point(528, 140);
            this.refreshCrewsButton.Name = "refreshCrewsButton";
            this.refreshCrewsButton.Size = new System.Drawing.Size(136, 30);
            this.refreshCrewsButton.TabIndex = 11;
            this.refreshCrewsButton.Text = "Обновить";
            this.refreshCrewsButton.UseVisualStyleBackColor = true;
            // 
            // editCrewButton
            // 
            this.editCrewButton.Location = new System.Drawing.Point(528, 68);
            this.editCrewButton.Name = "editCrewButton";
            this.editCrewButton.Size = new System.Drawing.Size(136, 30);
            this.editCrewButton.TabIndex = 10;
            this.editCrewButton.Text = "Изменить";
            this.editCrewButton.UseVisualStyleBackColor = true;
            // 
            // addCrewButton
            // 
            this.addCrewButton.Location = new System.Drawing.Point(528, 32);
            this.addCrewButton.Name = "addCrewButton";
            this.addCrewButton.Size = new System.Drawing.Size(136, 30);
            this.addCrewButton.TabIndex = 9;
            this.addCrewButton.Text = "Добавить";
            this.addCrewButton.UseVisualStyleBackColor = true;
            // 
            // crewsDataGridView
            // 
            this.crewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewsDataGridView.Location = new System.Drawing.Point(6, 32);
            this.crewsDataGridView.Name = "crewsDataGridView";
            this.crewsDataGridView.RowTemplate.Height = 24;
            this.crewsDataGridView.Size = new System.Drawing.Size(516, 272);
            this.crewsDataGridView.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 762);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button refreshContractsButton1;
        private System.Windows.Forms.Button editContractButton;
        private System.Windows.Forms.Button addContractButton;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

