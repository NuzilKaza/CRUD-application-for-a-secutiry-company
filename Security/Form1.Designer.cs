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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contractsTabPage = new System.Windows.Forms.TabPage();
            this.refreshContractsButton = new System.Windows.Forms.Button();
            this.editContractButton = new System.Windows.Forms.Button();
            this.addContractButton = new System.Windows.Forms.Button();
            this.contractsCountLabel = new System.Windows.Forms.Label();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.contractAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departuresTabPage = new System.Windows.Forms.TabPage();
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
            this.securityDataSet = new Security.SecurityDataSet();
            this.contracts_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contracts_viewTableAdapter = new Security.SecurityDataSetTableAdapters.contracts_viewTableAdapter();
            this.tableAdapterManager = new Security.SecurityDataSetTableAdapters.TableAdapterManager();
            this.номерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewsTableAdapter = new Security.SecurityDataSetTableAdapters.CrewsTableAdapter();
            this.crewidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewleaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewcarmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departuresTableAdapter = new Security.SecurityDataSetTableAdapters.DeparturesTableAdapter();
            this.departureidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuredatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falsecallDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.contractsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.departuresTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departuresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewIdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contracts_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.contractsTabPage);
            this.tabControl1.Controls.Add(this.departuresTabPage);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 799);
            this.tabControl1.TabIndex = 0;
            // 
            // contractsTabPage
            // 
            this.contractsTabPage.Controls.Add(this.refreshContractsButton);
            this.contractsTabPage.Controls.Add(this.editContractButton);
            this.contractsTabPage.Controls.Add(this.addContractButton);
            this.contractsTabPage.Controls.Add(this.contractsCountLabel);
            this.contractsTabPage.Controls.Add(this.contractsDataGridView);
            this.contractsTabPage.Controls.Add(this.contractAddressTextBox);
            this.contractsTabPage.Controls.Add(this.label2);
            this.contractsTabPage.Controls.Add(this.nameTextBox);
            this.contractsTabPage.Controls.Add(this.label1);
            this.contractsTabPage.Location = new System.Drawing.Point(4, 25);
            this.contractsTabPage.Name = "contractsTabPage";
            this.contractsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractsTabPage.Size = new System.Drawing.Size(944, 770);
            this.contractsTabPage.TabIndex = 0;
            this.contractsTabPage.Text = "Договоры";
            this.contractsTabPage.UseVisualStyleBackColor = true;
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
            this.contractsDataGridView.AutoGenerateColumns = false;
            this.contractsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДоговораDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn,
            this.телефонКлиентаDataGridViewTextBoxColumn});
            this.contractsDataGridView.DataSource = this.contracts_viewBindingSource;
            this.contractsDataGridView.Location = new System.Drawing.Point(9, 76);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.RowTemplate.Height = 24;
            this.contractsDataGridView.Size = new System.Drawing.Size(745, 688);
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
            // departuresTabPage
            // 
            this.departuresTabPage.Controls.Add(this.groupBox2);
            this.departuresTabPage.Controls.Add(this.groupBox1);
            this.departuresTabPage.Location = new System.Drawing.Point(4, 25);
            this.departuresTabPage.Name = "departuresTabPage";
            this.departuresTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.departuresTabPage.Size = new System.Drawing.Size(944, 770);
            this.departuresTabPage.TabIndex = 1;
            this.departuresTabPage.Text = "Выезды";
            this.departuresTabPage.UseVisualStyleBackColor = true;
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
            this.departuresDataGridView.AutoGenerateColumns = false;
            this.departuresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.departuresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departuresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureidDataGridViewTextBoxColumn,
            this.crewidDataGridViewTextBoxColumn1,
            this.contractidDataGridViewTextBoxColumn,
            this.departuredatetimeDataGridViewTextBoxColumn,
            this.falsecallDataGridViewCheckBoxColumn});
            this.departuresDataGridView.DataSource = this.departuresBindingSource;
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
            this.crewsDataGridView.AutoGenerateColumns = false;
            this.crewsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.crewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crewidDataGridViewTextBoxColumn,
            this.crewleaderDataGridViewTextBoxColumn,
            this.crewcarmodelDataGridViewTextBoxColumn});
            this.crewsDataGridView.DataSource = this.crewsBindingSource;
            this.crewsDataGridView.Location = new System.Drawing.Point(6, 45);
            this.crewsDataGridView.Name = "crewsDataGridView";
            this.crewsDataGridView.RowTemplate.Height = 24;
            this.crewsDataGridView.Size = new System.Drawing.Size(516, 249);
            this.crewsDataGridView.TabIndex = 0;
            // 
            // securityDataSet
            // 
            this.securityDataSet.DataSetName = "SecurityDataSet";
            this.securityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contracts_viewBindingSource
            // 
            this.contracts_viewBindingSource.DataMember = "contracts_view";
            this.contracts_viewBindingSource.DataSource = this.securityDataSet;
            // 
            // contracts_viewTableAdapter
            // 
            this.contracts_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Apartments_with_balconyTableAdapter = null;
            this.tableAdapterManager.Apartments_without_balconyTableAdapter = null;
            this.tableAdapterManager.ApartmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.CrewsTableAdapter = this.crewsTableAdapter;
            this.tableAdapterManager.DeparturesTableAdapter = this.departuresTableAdapter;
            this.tableAdapterManager.False_departuresTableAdapter = null;
            this.tableAdapterManager.HousesTableAdapter = null;
            this.tableAdapterManager.True_departuresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Security.SecurityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            this.номерДоговораDataGridViewTextBoxColumn.Width = 132;
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.Width = 118;
            // 
            // адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn
            // 
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn.DataPropertyName = "Адрес квартиры, указанной в договре";
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn.HeaderText = "Адрес квартиры, указанной в договре";
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn.Name = "адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn";
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn.ReadOnly = true;
            this.адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn.Width = 215;
            // 
            // телефонКлиентаDataGridViewTextBoxColumn
            // 
            this.телефонКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Телефон клиента";
            this.телефонКлиентаDataGridViewTextBoxColumn.HeaderText = "Телефон клиента";
            this.телефонКлиентаDataGridViewTextBoxColumn.Name = "телефонКлиентаDataGridViewTextBoxColumn";
            this.телефонКлиентаDataGridViewTextBoxColumn.Width = 142;
            // 
            // crewsBindingSource
            // 
            this.crewsBindingSource.DataMember = "Crews";
            this.crewsBindingSource.DataSource = this.securityDataSet;
            // 
            // crewsTableAdapter
            // 
            this.crewsTableAdapter.ClearBeforeFill = true;
            // 
            // crewidDataGridViewTextBoxColumn
            // 
            this.crewidDataGridViewTextBoxColumn.DataPropertyName = "crew_id";
            this.crewidDataGridViewTextBoxColumn.HeaderText = "crew_id";
            this.crewidDataGridViewTextBoxColumn.Name = "crewidDataGridViewTextBoxColumn";
            this.crewidDataGridViewTextBoxColumn.Width = 85;
            // 
            // crewleaderDataGridViewTextBoxColumn
            // 
            this.crewleaderDataGridViewTextBoxColumn.DataPropertyName = "crew_leader";
            this.crewleaderDataGridViewTextBoxColumn.HeaderText = "crew_leader";
            this.crewleaderDataGridViewTextBoxColumn.Name = "crewleaderDataGridViewTextBoxColumn";
            this.crewleaderDataGridViewTextBoxColumn.Width = 114;
            // 
            // crewcarmodelDataGridViewTextBoxColumn
            // 
            this.crewcarmodelDataGridViewTextBoxColumn.DataPropertyName = "crew_car_model";
            this.crewcarmodelDataGridViewTextBoxColumn.HeaderText = "crew_car_model";
            this.crewcarmodelDataGridViewTextBoxColumn.Name = "crewcarmodelDataGridViewTextBoxColumn";
            this.crewcarmodelDataGridViewTextBoxColumn.Width = 140;
            // 
            // departuresBindingSource
            // 
            this.departuresBindingSource.DataMember = "Departures";
            this.departuresBindingSource.DataSource = this.securityDataSet;
            // 
            // departuresTableAdapter
            // 
            this.departuresTableAdapter.ClearBeforeFill = true;
            // 
            // departureidDataGridViewTextBoxColumn
            // 
            this.departureidDataGridViewTextBoxColumn.DataPropertyName = "departure_id";
            this.departureidDataGridViewTextBoxColumn.HeaderText = "departure_id";
            this.departureidDataGridViewTextBoxColumn.Name = "departureidDataGridViewTextBoxColumn";
            this.departureidDataGridViewTextBoxColumn.Width = 118;
            // 
            // crewidDataGridViewTextBoxColumn1
            // 
            this.crewidDataGridViewTextBoxColumn1.DataPropertyName = "crew_id";
            this.crewidDataGridViewTextBoxColumn1.HeaderText = "crew_id";
            this.crewidDataGridViewTextBoxColumn1.Name = "crewidDataGridViewTextBoxColumn1";
            this.crewidDataGridViewTextBoxColumn1.Width = 85;
            // 
            // contractidDataGridViewTextBoxColumn
            // 
            this.contractidDataGridViewTextBoxColumn.DataPropertyName = "contract_id";
            this.contractidDataGridViewTextBoxColumn.HeaderText = "contract_id";
            this.contractidDataGridViewTextBoxColumn.Name = "contractidDataGridViewTextBoxColumn";
            this.contractidDataGridViewTextBoxColumn.Width = 107;
            // 
            // departuredatetimeDataGridViewTextBoxColumn
            // 
            this.departuredatetimeDataGridViewTextBoxColumn.DataPropertyName = "departure_date_time";
            this.departuredatetimeDataGridViewTextBoxColumn.HeaderText = "departure_date_time";
            this.departuredatetimeDataGridViewTextBoxColumn.Name = "departuredatetimeDataGridViewTextBoxColumn";
            this.departuredatetimeDataGridViewTextBoxColumn.Width = 169;
            // 
            // falsecallDataGridViewCheckBoxColumn
            // 
            this.falsecallDataGridViewCheckBoxColumn.DataPropertyName = "false_call";
            this.falsecallDataGridViewCheckBoxColumn.HeaderText = "false_call";
            this.falsecallDataGridViewCheckBoxColumn.Name = "falsecallDataGridViewCheckBoxColumn";
            this.falsecallDataGridViewCheckBoxColumn.Width = 73;
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
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.contractsTabPage.ResumeLayout(false);
            this.contractsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            this.departuresTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departuresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewIdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contracts_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departuresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage contractsTabPage;
        private System.Windows.Forms.TextBox contractAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage departuresTabPage;
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
        private SecurityDataSet securityDataSet;
        private System.Windows.Forms.BindingSource contracts_viewBindingSource;
        private SecurityDataSetTableAdapters.contracts_viewTableAdapter contracts_viewTableAdapter;
        private SecurityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресКвартирыУказаннойВДоговреDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонКлиентаDataGridViewTextBoxColumn;
        private SecurityDataSetTableAdapters.CrewsTableAdapter crewsTableAdapter;
        private System.Windows.Forms.BindingSource crewsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewleaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewcarmodelDataGridViewTextBoxColumn;
        private SecurityDataSetTableAdapters.DeparturesTableAdapter departuresTableAdapter;
        private System.Windows.Forms.BindingSource departuresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuredatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn falsecallDataGridViewCheckBoxColumn;
    }
}

