
namespace SmallBusinessAccountantApp
{
    partial class MainForm
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
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label positionNameLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label passportDataLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contractNumberLabel;
            System.Windows.Forms.Label conclusionDateLabel;
            System.Windows.Forms.Label expirationDateLabel;
            System.Windows.Forms.Label employeeIdLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label creationDateLabel;
            System.Windows.Forms.Label employeeIdLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sBADataSet = new SmallBusinessAccountantApp.SBADataSet();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.positionNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passportDataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contractNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conclusionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expirationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.accountNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeIdComboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeesTableAdapter = new SmallBusinessAccountantApp.SBADataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new SmallBusinessAccountantApp.SBADataSetTableAdapters.TableAdapterManager();
            this.accountsTableAdapter = new SmallBusinessAccountantApp.SBADataSetTableAdapters.AccountsTableAdapter();
            this.contractsTableAdapter = new SmallBusinessAccountantApp.SBADataSetTableAdapters.ContractsTableAdapter();
            surnameLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            positionNameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            passportDataLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contractNumberLabel = new System.Windows.Forms.Label();
            conclusionDateLabel = new System.Windows.Forms.Label();
            expirationDateLabel = new System.Windows.Forms.Label();
            employeeIdLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            creationDateLabel = new System.Windows.Forms.Label();
            employeeIdLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            surnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(860, 40);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(59, 13);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "Фамилия:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(860, 66);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(32, 13);
            firstnameLabel.TabIndex = 4;
            firstnameLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(860, 92);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(57, 13);
            patronymicLabel.TabIndex = 6;
            patronymicLabel.Text = "Отчество:";
            // 
            // positionNameLabel
            // 
            positionNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            positionNameLabel.AutoSize = true;
            positionNameLabel.Location = new System.Drawing.Point(860, 118);
            positionNameLabel.Name = "positionNameLabel";
            positionNameLabel.Size = new System.Drawing.Size(68, 13);
            positionNameLabel.TabIndex = 8;
            positionNameLabel.Text = "Должность:";
            // 
            // salaryLabel
            // 
            salaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(860, 143);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(68, 13);
            salaryLabel.TabIndex = 10;
            salaryLabel.Text = "Оклад, руб.:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(860, 170);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(96, 13);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Номер телефона:";
            // 
            // passportDataLabel
            // 
            passportDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passportDataLabel.AutoSize = true;
            passportDataLabel.Location = new System.Drawing.Point(860, 196);
            passportDataLabel.Name = "passportDataLabel";
            passportDataLabel.Size = new System.Drawing.Size(114, 13);
            passportDataLabel.TabIndex = 14;
            passportDataLabel.Text = "Паспортные данные:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(860, 222);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(41, 13);
            addressLabel.TabIndex = 16;
            addressLabel.Text = "Адрес:";
            // 
            // contractNumberLabel
            // 
            contractNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            contractNumberLabel.AutoSize = true;
            contractNumberLabel.Location = new System.Drawing.Point(863, 45);
            contractNumberLabel.Name = "contractNumberLabel";
            contractNumberLabel.Size = new System.Drawing.Size(71, 13);
            contractNumberLabel.TabIndex = 3;
            contractNumberLabel.Text = "№ договора:";
            // 
            // conclusionDateLabel
            // 
            conclusionDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            conclusionDateLabel.AutoSize = true;
            conclusionDateLabel.Location = new System.Drawing.Point(863, 72);
            conclusionDateLabel.Name = "conclusionDateLabel";
            conclusionDateLabel.Size = new System.Drawing.Size(100, 13);
            conclusionDateLabel.TabIndex = 5;
            conclusionDateLabel.Text = "Дата заключения:";
            // 
            // expirationDateLabel
            // 
            expirationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            expirationDateLabel.AutoSize = true;
            expirationDateLabel.Location = new System.Drawing.Point(863, 98);
            expirationDateLabel.Name = "expirationDateLabel";
            expirationDateLabel.Size = new System.Drawing.Size(92, 13);
            expirationDateLabel.TabIndex = 7;
            expirationDateLabel.Text = "Дата окончания:";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new System.Drawing.Point(863, 123);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new System.Drawing.Size(63, 13);
            employeeIdLabel.TabIndex = 9;
            employeeIdLabel.Text = "Сотрудник:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(853, 41);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(52, 13);
            accountNumberLabel.TabIndex = 4;
            accountNumberLabel.Text = "№ счета:";
            // 
            // creationDateLabel
            // 
            creationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            creationDateLabel.AutoSize = true;
            creationDateLabel.Location = new System.Drawing.Point(853, 68);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new System.Drawing.Size(87, 13);
            creationDateLabel.TabIndex = 6;
            creationDateLabel.Text = "Дата создания:";
            // 
            // employeeIdLabel1
            // 
            employeeIdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeIdLabel1.AutoSize = true;
            employeeIdLabel1.Location = new System.Drawing.Point(853, 93);
            employeeIdLabel1.Name = "employeeIdLabel1";
            employeeIdLabel1.Size = new System.Drawing.Size(63, 13);
            employeeIdLabel1.TabIndex = 8;
            employeeIdLabel1.Text = "Сотрудник:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(surnameLabel);
            this.tabPage1.Controls.Add(this.surnameTextBox);
            this.tabPage1.Controls.Add(firstnameLabel);
            this.tabPage1.Controls.Add(this.firstnameTextBox);
            this.tabPage1.Controls.Add(patronymicLabel);
            this.tabPage1.Controls.Add(this.patronymicTextBox);
            this.tabPage1.Controls.Add(positionNameLabel);
            this.tabPage1.Controls.Add(this.positionNameTextBox);
            this.tabPage1.Controls.Add(salaryLabel);
            this.tabPage1.Controls.Add(this.salaryNumericUpDown);
            this.tabPage1.Controls.Add(phoneNumberLabel);
            this.tabPage1.Controls.Add(this.phoneNumberMaskedTextBox);
            this.tabPage1.Controls.Add(passportDataLabel);
            this.tabPage1.Controls.Add(this.passportDataMaskedTextBox);
            this.tabPage1.Controls.Add(addressLabel);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(this.employeesBindingNavigator);
            this.tabPage1.Controls.Add(this.employeesDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(947, 37);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(237, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sBADataSet;
            // 
            // sBADataSet
            // 
            this.sBADataSet.DataSetName = "SBADataSet";
            this.sBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(947, 63);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(237, 20);
            this.firstnameTextBox.TabIndex = 5;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(947, 89);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(237, 20);
            this.patronymicTextBox.TabIndex = 7;
            // 
            // positionNameTextBox
            // 
            this.positionNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PositionName", true));
            this.positionNameTextBox.Location = new System.Drawing.Point(947, 115);
            this.positionNameTextBox.Name = "positionNameTextBox";
            this.positionNameTextBox.Size = new System.Drawing.Size(237, 20);
            this.positionNameTextBox.TabIndex = 9;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "Salary", true));
            this.salaryNumericUpDown.DecimalPlaces = 2;
            this.salaryNumericUpDown.Location = new System.Drawing.Point(947, 141);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(237, 20);
            this.salaryNumericUpDown.TabIndex = 11;
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PhoneNumber", true));
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(980, 167);
            this.phoneNumberMaskedTextBox.Mask = "+7(000)000-00-00";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(204, 20);
            this.phoneNumberMaskedTextBox.TabIndex = 13;
            // 
            // passportDataMaskedTextBox
            // 
            this.passportDataMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passportDataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PassportData", true));
            this.passportDataMaskedTextBox.Location = new System.Drawing.Point(980, 193);
            this.passportDataMaskedTextBox.Mask = "0000 000000";
            this.passportDataMaskedTextBox.Name = "passportDataMaskedTextBox";
            this.passportDataMaskedTextBox.Size = new System.Drawing.Size(204, 20);
            this.passportDataMaskedTextBox.TabIndex = 15;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(947, 219);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(237, 84);
            this.addressTextBox.TabIndex = 17;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeesBindingNavigatorSaveItem});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(1209, 25);
            this.employeesBindingNavigator.TabIndex = 2;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(6, 31);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(837, 424);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PositionName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn6.HeaderText = "Оклад, руб.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PassportData";
            this.dataGridViewTextBoxColumn8.HeaderText = "Паспортные данные";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn9.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(contractNumberLabel);
            this.tabPage2.Controls.Add(this.contractNumberNumericUpDown);
            this.tabPage2.Controls.Add(conclusionDateLabel);
            this.tabPage2.Controls.Add(this.conclusionDateDateTimePicker);
            this.tabPage2.Controls.Add(expirationDateLabel);
            this.tabPage2.Controls.Add(this.expirationDateDateTimePicker);
            this.tabPage2.Controls.Add(employeeIdLabel);
            this.tabPage2.Controls.Add(this.employeeIdComboBox);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(this.contractsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Договоры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contractNumberNumericUpDown
            // 
            this.contractNumberNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contractNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsBindingSource, "ContractNumber", true));
            this.contractNumberNumericUpDown.Location = new System.Drawing.Point(971, 42);
            this.contractNumberNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.contractNumberNumericUpDown.Name = "contractNumberNumericUpDown";
            this.contractNumberNumericUpDown.Size = new System.Drawing.Size(222, 20);
            this.contractNumberNumericUpDown.TabIndex = 4;
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "Contracts";
            this.contractsBindingSource.DataSource = this.sBADataSet;
            // 
            // conclusionDateDateTimePicker
            // 
            this.conclusionDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.conclusionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsBindingSource, "ConclusionDate", true));
            this.conclusionDateDateTimePicker.Location = new System.Drawing.Point(971, 68);
            this.conclusionDateDateTimePicker.Name = "conclusionDateDateTimePicker";
            this.conclusionDateDateTimePicker.Size = new System.Drawing.Size(222, 20);
            this.conclusionDateDateTimePicker.TabIndex = 6;
            // 
            // expirationDateDateTimePicker
            // 
            this.expirationDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expirationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsBindingSource, "ExpirationDate", true));
            this.expirationDateDateTimePicker.Location = new System.Drawing.Point(971, 94);
            this.expirationDateDateTimePicker.Name = "expirationDateDateTimePicker";
            this.expirationDateDateTimePicker.Size = new System.Drawing.Size(222, 20);
            this.expirationDateDateTimePicker.TabIndex = 8;
            // 
            // employeeIdComboBox
            // 
            this.employeeIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "EmployeeId", true));
            this.employeeIdComboBox.DataSource = this.employeesBindingSource;
            this.employeeIdComboBox.DisplayMember = "Surname";
            this.employeeIdComboBox.FormattingEnabled = true;
            this.employeeIdComboBox.Location = new System.Drawing.Point(971, 120);
            this.employeeIdComboBox.Name = "employeeIdComboBox";
            this.employeeIdComboBox.Size = new System.Drawing.Size(222, 21);
            this.employeeIdComboBox.TabIndex = 10;
            this.employeeIdComboBox.ValueMember = "Id";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.contractsBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1201, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Сохранить данные";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AllowUserToAddRows = false;
            this.contractsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractsDataGridView.AutoGenerateColumns = false;
            this.contractsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contractsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.contractsDataGridView.DataSource = this.contractsBindingSource;
            this.contractsDataGridView.Location = new System.Drawing.Point(6, 31);
            this.contractsDataGridView.MultiSelect = false;
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.ReadOnly = true;
            this.contractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractsDataGridView.Size = new System.Drawing.Size(840, 428);
            this.contractsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ContractNumber";
            this.dataGridViewTextBoxColumn10.FillWeight = 60F;
            this.dataGridViewTextBoxColumn10.HeaderText = "№ договора";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ConclusionDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата заключения";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ExpirationDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn13.DataSource = this.employeesBindingSource;
            this.dataGridViewTextBoxColumn13.DisplayMember = "Surname";
            this.dataGridViewTextBoxColumn13.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.ValueMember = "Id";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(accountNumberLabel);
            this.tabPage3.Controls.Add(this.accountNumberNumericUpDown);
            this.tabPage3.Controls.Add(creationDateLabel);
            this.tabPage3.Controls.Add(this.creationDateDateTimePicker);
            this.tabPage3.Controls.Add(employeeIdLabel1);
            this.tabPage3.Controls.Add(this.employeeIdComboBox1);
            this.tabPage3.Controls.Add(this.bindingNavigator2);
            this.tabPage3.Controls.Add(this.accountsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1207, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Счета";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // accountNumberNumericUpDown
            // 
            this.accountNumberNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountsBindingSource, "AccountNumber", true));
            this.accountNumberNumericUpDown.Location = new System.Drawing.Point(949, 38);
            this.accountNumberNumericUpDown.Name = "accountNumberNumericUpDown";
            this.accountNumberNumericUpDown.Size = new System.Drawing.Size(244, 20);
            this.accountNumberNumericUpDown.TabIndex = 5;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.sBADataSet;
            // 
            // creationDateDateTimePicker
            // 
            this.creationDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountsBindingSource, "CreationDate", true));
            this.creationDateDateTimePicker.Location = new System.Drawing.Point(949, 64);
            this.creationDateDateTimePicker.Name = "creationDateDateTimePicker";
            this.creationDateDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.creationDateDateTimePicker.TabIndex = 7;
            // 
            // employeeIdComboBox1
            // 
            this.employeeIdComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountsBindingSource, "EmployeeId", true));
            this.employeeIdComboBox1.DataSource = this.employeesBindingSource;
            this.employeeIdComboBox1.DisplayMember = "Surname";
            this.employeeIdComboBox1.FormattingEnabled = true;
            this.employeeIdComboBox1.Location = new System.Drawing.Point(949, 90);
            this.employeeIdComboBox1.Name = "employeeIdComboBox1";
            this.employeeIdComboBox1.Size = new System.Drawing.Size(244, 21);
            this.employeeIdComboBox1.TabIndex = 9;
            this.employeeIdComboBox1.ValueMember = "Id";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.BindingSource = this.accountsBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14,
            this.toolStripSeparator7,
            this.toolStripButton15,
            this.toolStripButton16});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(1207, 25);
            this.bindingNavigator2.TabIndex = 4;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Добавить";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "для {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Сохранить данные";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton15.Text = "Поощрения";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton16.Text = "Взыскания";
            this.toolStripButton16.Click += new System.EventHandler(this.toolStripButton16_Click);
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.AllowUserToAddRows = false;
            this.accountsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsDataGridView.AutoGenerateColumns = false;
            this.accountsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.accountsDataGridView.DataSource = this.accountsBindingSource;
            this.accountsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.accountsDataGridView.MultiSelect = false;
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.ReadOnly = true;
            this.accountsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountsDataGridView.Size = new System.Drawing.Size(831, 434);
            this.accountsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AccountNumber";
            this.dataGridViewTextBoxColumn14.FillWeight = 60F;
            this.dataGridViewTextBoxColumn14.HeaderText = "№ счета";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CreationDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "Дата создания";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn16.DataSource = this.employeesBindingSource;
            this.dataGridViewTextBoxColumn16.DisplayMember = "Surname";
            this.dataGridViewTextBoxColumn16.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn16.ValueMember = "Id";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableAdapter = this.accountsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = this.contractsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.PenaltiesTableAdapter = null;
            this.tableAdapterManager.PromotionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SmallBusinessAccountantApp.SBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа \"Бухгалтер малого предприятия\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private SBADataSet sBADataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SBADataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private SBADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox positionNameTextBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox passportDataMaskedTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private SBADataSetTableAdapters.ContractsTableAdapter contractsTableAdapter;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.NumericUpDown contractNumberNumericUpDown;
        private System.Windows.Forms.DateTimePicker conclusionDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker expirationDateDateTimePicker;
        private System.Windows.Forms.ComboBox employeeIdComboBox;
        private SBADataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.DataGridView accountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.NumericUpDown accountNumberNumericUpDown;
        private System.Windows.Forms.DateTimePicker creationDateDateTimePicker;
        private System.Windows.Forms.ComboBox employeeIdComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
    }
}

