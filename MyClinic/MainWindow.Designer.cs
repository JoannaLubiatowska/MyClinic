namespace MyClinic
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label serviceDescriptionLabel;
            System.Windows.Forms.Label serviceNameLabel;
            System.Windows.Forms.Label examinationDateLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label medicalServiceIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label examinationDescriptionLabel;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label visitDateLabel;
            System.Windows.Forms.Label medicalSpecialistLabel;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            this.exterminations_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MyClinic.DataSet();
            this.visits_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.employee_viewTableAdapter = new MyClinic.DataSetTableAdapters.Employee_viewTableAdapter();
            this.tableAdapterManager = new MyClinic.DataSetTableAdapters.TableAdapterManager();
            this.clinicEmployeesTableAdapter = new MyClinic.DataSetTableAdapters.ClinicEmployeesTableAdapter();
            this.medicalServicesTableAdapter = new MyClinic.DataSetTableAdapters.MedicalServicesTableAdapter();
            this.visits_viewTableAdapter = new MyClinic.DataSetTableAdapters.Visits_viewTableAdapter();
            this.exterminations_viewTableAdapter = new MyClinic.DataSetTableAdapters.Exterminations_viewTableAdapter();
            this.patientsTableAdapter = new MyClinic.DataSetTableAdapters.PatientsTableAdapter();
            this.tabAdministration = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonEditEployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.clinicEmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonEditService = new System.Windows.Forms.Button();
            this.medicalServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxAdministrationServiceName = new System.Windows.Forms.TextBox();
            this.textBoxAdministrationServiceDescription = new System.Windows.Forms.TextBox();
            this.textBoxAdministrationServicePrice = new System.Windows.Forms.TextBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxServicesServiceName = new System.Windows.Forms.ComboBox();
            this.textBoxServicesPesel = new System.Windows.Forms.TextBox();
            this.dateTimePickerServicesDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxServicesDoctor = new System.Windows.Forms.ComboBox();
            this.buttonServicePatientSearch = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxServicesLastName = new System.Windows.Forms.TextBox();
            this.textBoxServicesFirstName = new System.Windows.Forms.TextBox();
            this.textBoxServicesStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxServicesStreet = new System.Windows.Forms.TextBox();
            this.textBoxServicesPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxServicesPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxServicesCity = new System.Windows.Forms.TextBox();
            this.textBoxServicesDescription = new System.Windows.Forms.TextBox();
            this.buttonSaveExamination = new System.Windows.Forms.Button();
            this.tabVistis = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxVisitPesel = new System.Windows.Forms.TextBox();
            this.dateTimePickerVisitDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVisitDoctor = new System.Windows.Forms.ComboBox();
            this.buttonVisitPatientSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxVisitArchiveDescription = new System.Windows.Forms.TextBox();
            this.textBoxVisitArchivCode = new System.Windows.Forms.TextBox();
            this.textBoxArchivMedicines = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxVisitLastName = new System.Windows.Forms.TextBox();
            this.textBoxVisitFirstName = new System.Windows.Forms.TextBox();
            this.textBoxVisitStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxVisitStreet = new System.Windows.Forms.TextBox();
            this.textBoxVisitPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxVisitCity = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonMedicines = new System.Windows.Forms.Button();
            this.textBoxVisitDescription = new System.Windows.Forms.TextBox();
            this.textBoxVisitCode = new System.Windows.Forms.TextBox();
            this.buttonSaveVisit = new System.Windows.Forms.Button();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.textBoxPatientPesel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.buttonSaveSchedule = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxSchedulerPesel = new System.Windows.Forms.TextBox();
            this.textBoxSchedulerFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSchedulerDoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSchedulerLastName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimePickerScheduler = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.buttonSearchPatient = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visits_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.exterminations_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSchedulerService = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.buttonSaveSchedulerExaminaion = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonShowArchive = new System.Windows.Forms.Button();
            priceLabel = new System.Windows.Forms.Label();
            serviceDescriptionLabel = new System.Windows.Forms.Label();
            serviceNameLabel = new System.Windows.Forms.Label();
            examinationDateLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            medicalServiceIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            examinationDescriptionLabel = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            visitDateLabel = new System.Windows.Forms.Label();
            medicalSpecialistLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesBindingSource)).BeginInit();
            this.tabAdministration.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesDataGridView)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataGridView)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabVistis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.tabSchedule.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewDataGridView)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // exterminations_viewBindingSource
            // 
            this.exterminations_viewBindingSource.DataMember = "Exterminations_view";
            this.exterminations_viewBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visits_viewBindingSource
            // 
            this.visits_viewBindingSource.DataMember = "Visits_view";
            this.visits_viewBindingSource.DataSource = this.dataSet;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dataSet;
            // 
            // medicalServicesBindingSource
            // 
            this.medicalServicesBindingSource.DataMember = "MedicalServices";
            this.medicalServicesBindingSource.DataSource = this.dataSet;
            // 
            // clinicEmployeesBindingSource
            // 
            this.clinicEmployeesBindingSource.DataMember = "ClinicEmployees";
            this.clinicEmployeesBindingSource.DataSource = this.dataSet;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(-1, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Przychodnia Medica";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(1117, 5);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(84, 23);
            this.LogoutButton.TabIndex = 25;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // employee_viewTableAdapter
            // 
            this.employee_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClinicEmployeesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MedicalServicesTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyClinic.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clinicEmployeesTableAdapter
            // 
            this.clinicEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // medicalServicesTableAdapter
            // 
            this.medicalServicesTableAdapter.ClearBeforeFill = true;
            // 
            // visits_viewTableAdapter
            // 
            this.visits_viewTableAdapter.ClearBeforeFill = true;
            // 
            // exterminations_viewTableAdapter
            // 
            this.exterminations_viewTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tabAdministration
            // 
            this.tabAdministration.AutoScroll = true;
            this.tabAdministration.Controls.Add(this.groupBox9);
            this.tabAdministration.Controls.Add(this.groupBox8);
            this.tabAdministration.Controls.Add(this.groupBox7);
            this.tabAdministration.Location = new System.Drawing.Point(4, 22);
            this.tabAdministration.Margin = new System.Windows.Forms.Padding(0);
            this.tabAdministration.Name = "tabAdministration";
            this.tabAdministration.Size = new System.Drawing.Size(1198, 658);
            this.tabAdministration.TabIndex = 4;
            this.tabAdministration.Text = "Administracja";
            this.tabAdministration.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.clinicEmployeesDataGridView);
            this.groupBox7.Controls.Add(this.buttonDeleteEmployee);
            this.groupBox7.Controls.Add(this.buttonAddEmployee);
            this.groupBox7.Controls.Add(this.buttonEditEployee);
            this.groupBox7.Location = new System.Drawing.Point(9, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(712, 645);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pracownicy";
            // 
            // buttonEditEployee
            // 
            this.buttonEditEployee.Location = new System.Drawing.Point(415, 616);
            this.buttonEditEployee.Name = "buttonEditEployee";
            this.buttonEditEployee.Size = new System.Drawing.Size(136, 23);
            this.buttonEditEployee.TabIndex = 5;
            this.buttonEditEployee.Text = "Edytuj pracownika";
            this.buttonEditEployee.UseVisualStyleBackColor = true;
            this.buttonEditEployee.Click += new System.EventHandler(this.buttonEditEployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(273, 616);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonAddEmployee.TabIndex = 4;
            this.buttonAddEmployee.Text = "Dodaj pracownika";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(556, 616);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonDeleteEmployee.TabIndex = 6;
            this.buttonDeleteEmployee.Text = "Usuń pracownika";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // clinicEmployeesDataGridView
            // 
            this.clinicEmployeesDataGridView.AutoGenerateColumns = false;
            this.clinicEmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clinicEmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.clinicEmployeesDataGridView.DataSource = this.clinicEmployeesBindingSource;
            this.clinicEmployeesDataGridView.Location = new System.Drawing.Point(16, 19);
            this.clinicEmployeesDataGridView.Name = "clinicEmployeesDataGridView";
            this.clinicEmployeesDataGridView.Size = new System.Drawing.Size(676, 588);
            this.clinicEmployeesDataGridView.TabIndex = 6;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Zatrudniony";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EmployeeDescription";
            this.dataGridViewTextBoxColumn9.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Numer telefonu";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.medicalServicesDataGridView);
            this.groupBox8.Controls.Add(this.buttonEditService);
            this.groupBox8.Location = new System.Drawing.Point(722, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(460, 456);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Usługi";
            // 
            // buttonEditService
            // 
            this.buttonEditService.Location = new System.Drawing.Point(304, 427);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(136, 23);
            this.buttonEditService.TabIndex = 8;
            this.buttonEditService.Text = "Edytuj usługę";
            this.buttonEditService.UseVisualStyleBackColor = true;
            this.buttonEditService.Click += new System.EventHandler(this.buttonEditService_Click);
            // 
            // medicalServicesDataGridView
            // 
            this.medicalServicesDataGridView.AutoGenerateColumns = false;
            this.medicalServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalServicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.medicalServicesDataGridView.DataSource = this.medicalServicesBindingSource;
            this.medicalServicesDataGridView.Location = new System.Drawing.Point(23, 19);
            this.medicalServicesDataGridView.Name = "medicalServicesDataGridView";
            this.medicalServicesDataGridView.Size = new System.Drawing.Size(417, 388);
            this.medicalServicesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ServiceDescription";
            this.dataGridViewTextBoxColumn5.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Usluga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.buttonAddService);
            this.groupBox9.Controls.Add(this.textBoxAdministrationServicePrice);
            this.groupBox9.Controls.Add(this.textBoxAdministrationServiceDescription);
            this.groupBox9.Controls.Add(serviceNameLabel);
            this.groupBox9.Controls.Add(serviceDescriptionLabel);
            this.groupBox9.Controls.Add(priceLabel);
            this.groupBox9.Controls.Add(this.textBoxAdministrationServiceName);
            this.groupBox9.Location = new System.Drawing.Point(722, 468);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(460, 183);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Nowa Usługa";
            // 
            // textBoxAdministrationServiceName
            // 
            this.textBoxAdministrationServiceName.Location = new System.Drawing.Point(98, 25);
            this.textBoxAdministrationServiceName.Name = "textBoxAdministrationServiceName";
            this.textBoxAdministrationServiceName.Size = new System.Drawing.Size(342, 20);
            this.textBoxAdministrationServiceName.TabIndex = 21;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(6, 128);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(35, 13);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "Cena:";
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.AutoSize = true;
            serviceDescriptionLabel.Location = new System.Drawing.Point(6, 54);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            serviceDescriptionLabel.TabIndex = 23;
            serviceDescriptionLabel.Text = "Opis:";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Location = new System.Drawing.Point(6, 28);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(75, 13);
            serviceNameLabel.TabIndex = 22;
            serviceNameLabel.Text = "Nazwa usługi:";
            // 
            // textBoxAdministrationServiceDescription
            // 
            this.textBoxAdministrationServiceDescription.Location = new System.Drawing.Point(98, 51);
            this.textBoxAdministrationServiceDescription.Multiline = true;
            this.textBoxAdministrationServiceDescription.Name = "textBoxAdministrationServiceDescription";
            this.textBoxAdministrationServiceDescription.Size = new System.Drawing.Size(342, 68);
            this.textBoxAdministrationServiceDescription.TabIndex = 25;
            // 
            // textBoxAdministrationServicePrice
            // 
            this.textBoxAdministrationServicePrice.Location = new System.Drawing.Point(98, 125);
            this.textBoxAdministrationServicePrice.Name = "textBoxAdministrationServicePrice";
            this.textBoxAdministrationServicePrice.Size = new System.Drawing.Size(342, 20);
            this.textBoxAdministrationServicePrice.TabIndex = 26;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(304, 154);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(136, 23);
            this.buttonAddService.TabIndex = 27;
            this.buttonAddService.Text = "Dodaj usługę";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.buttonSaveExamination);
            this.tabServices.Controls.Add(this.textBoxServicesDescription);
            this.tabServices.Controls.Add(examinationDescriptionLabel);
            this.tabServices.Controls.Add(this.groupBox6);
            this.tabServices.Controls.Add(this.groupBox5);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(1198, 658);
            this.tabServices.TabIndex = 3;
            this.tabServices.Text = "Usługi";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonServicePatientSearch);
            this.groupBox5.Controls.Add(this.comboBoxServicesDoctor);
            this.groupBox5.Controls.Add(this.dateTimePickerServicesDate);
            this.groupBox5.Controls.Add(this.textBoxServicesPesel);
            this.groupBox5.Controls.Add(this.comboBoxServicesServiceName);
            this.groupBox5.Controls.Add(employeeIDLabel);
            this.groupBox5.Controls.Add(medicalServiceIDLabel);
            this.groupBox5.Controls.Add(patientIDLabel);
            this.groupBox5.Controls.Add(examinationDateLabel);
            this.groupBox5.Location = new System.Drawing.Point(9, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(426, 319);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Szczegóły";
            // 
            // examinationDateLabel
            // 
            examinationDateLabel.AutoSize = true;
            examinationDateLabel.Location = new System.Drawing.Point(6, 130);
            examinationDateLabel.Name = "examinationDateLabel";
            examinationDateLabel.Size = new System.Drawing.Size(128, 13);
            examinationDateLabel.TabIndex = 43;
            examinationDateLabel.Text = "Data wykonania badania:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(6, 101);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(88, 13);
            patientIDLabel.TabIndex = 41;
            patientIDLabel.Text = "PESEL pacjenta:";
            // 
            // medicalServiceIDLabel
            // 
            medicalServiceIDLabel.AutoSize = true;
            medicalServiceIDLabel.Location = new System.Drawing.Point(6, 75);
            medicalServiceIDLabel.Name = "medicalServiceIDLabel";
            medicalServiceIDLabel.Size = new System.Drawing.Size(75, 13);
            medicalServiceIDLabel.TabIndex = 40;
            medicalServiceIDLabel.Text = "Nazwa usługi:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(6, 49);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(142, 13);
            employeeIDLabel.TabIndex = 39;
            employeeIDLabel.Text = "Osoba wykonująca badanie:";
            // 
            // comboBoxServicesServiceName
            // 
            this.comboBoxServicesServiceName.FormattingEnabled = true;
            this.comboBoxServicesServiceName.Location = new System.Drawing.Point(173, 72);
            this.comboBoxServicesServiceName.Name = "comboBoxServicesServiceName";
            this.comboBoxServicesServiceName.Size = new System.Drawing.Size(242, 21);
            this.comboBoxServicesServiceName.TabIndex = 45;
            // 
            // textBoxServicesPesel
            // 
            this.textBoxServicesPesel.Location = new System.Drawing.Point(173, 98);
            this.textBoxServicesPesel.Name = "textBoxServicesPesel";
            this.textBoxServicesPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPesel.TabIndex = 46;
            // 
            // dateTimePickerServicesDate
            // 
            this.dateTimePickerServicesDate.Location = new System.Drawing.Point(173, 124);
            this.dateTimePickerServicesDate.Name = "dateTimePickerServicesDate";
            this.dateTimePickerServicesDate.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerServicesDate.TabIndex = 48;
            // 
            // comboBoxServicesDoctor
            // 
            this.comboBoxServicesDoctor.FormattingEnabled = true;
            this.comboBoxServicesDoctor.Location = new System.Drawing.Point(173, 46);
            this.comboBoxServicesDoctor.Name = "comboBoxServicesDoctor";
            this.comboBoxServicesDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxServicesDoctor.TabIndex = 49;
            // 
            // buttonServicePatientSearch
            // 
            this.buttonServicePatientSearch.Location = new System.Drawing.Point(331, 150);
            this.buttonServicePatientSearch.Name = "buttonServicePatientSearch";
            this.buttonServicePatientSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonServicePatientSearch.TabIndex = 50;
            this.buttonServicePatientSearch.Text = "Szukaj";
            this.buttonServicePatientSearch.UseVisualStyleBackColor = true;
            this.buttonServicePatientSearch.Click += new System.EventHandler(this.buttonServicePatientSearch_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxServicesCity);
            this.groupBox6.Controls.Add(this.textBoxServicesPhoneNo);
            this.groupBox6.Controls.Add(this.textBoxServicesPostalCode);
            this.groupBox6.Controls.Add(this.textBoxServicesStreet);
            this.groupBox6.Controls.Add(this.textBoxServicesStreetNo);
            this.groupBox6.Controls.Add(this.textBoxServicesFirstName);
            this.groupBox6.Controls.Add(this.textBoxServicesLastName);
            this.groupBox6.Controls.Add(label14);
            this.groupBox6.Controls.Add(label23);
            this.groupBox6.Controls.Add(label24);
            this.groupBox6.Controls.Add(label25);
            this.groupBox6.Controls.Add(label26);
            this.groupBox6.Controls.Add(label27);
            this.groupBox6.Controls.Add(label28);
            this.groupBox6.Location = new System.Drawing.Point(9, 331);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(426, 291);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dane pacjenta";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(6, 204);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(82, 13);
            label28.TabIndex = 21;
            label28.Text = "Numer telefonu:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(6, 178);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(41, 13);
            label27.TabIndex = 20;
            label27.Text = "Miasto:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(6, 152);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(77, 13);
            label26.TabIndex = 19;
            label26.Text = "Kod pocztowy:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(6, 126);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(70, 13);
            label25.TabIndex = 18;
            label25.Text = "Numer domu:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(6, 100);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(34, 13);
            label24.TabIndex = 17;
            label24.Text = "Ulica:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(6, 74);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(56, 13);
            label23.TabIndex = 16;
            label23.Text = "Nazwisko:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 48);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 13);
            label14.TabIndex = 15;
            label14.Text = "Imię:";
            // 
            // textBoxServicesLastName
            // 
            this.textBoxServicesLastName.Enabled = false;
            this.textBoxServicesLastName.Location = new System.Drawing.Point(173, 71);
            this.textBoxServicesLastName.Name = "textBoxServicesLastName";
            this.textBoxServicesLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesLastName.TabIndex = 23;
            // 
            // textBoxServicesFirstName
            // 
            this.textBoxServicesFirstName.Enabled = false;
            this.textBoxServicesFirstName.Location = new System.Drawing.Point(173, 45);
            this.textBoxServicesFirstName.Name = "textBoxServicesFirstName";
            this.textBoxServicesFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesFirstName.TabIndex = 24;
            // 
            // textBoxServicesStreetNo
            // 
            this.textBoxServicesStreetNo.Enabled = false;
            this.textBoxServicesStreetNo.Location = new System.Drawing.Point(173, 123);
            this.textBoxServicesStreetNo.Name = "textBoxServicesStreetNo";
            this.textBoxServicesStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesStreetNo.TabIndex = 25;
            // 
            // textBoxServicesStreet
            // 
            this.textBoxServicesStreet.Enabled = false;
            this.textBoxServicesStreet.Location = new System.Drawing.Point(173, 97);
            this.textBoxServicesStreet.Name = "textBoxServicesStreet";
            this.textBoxServicesStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesStreet.TabIndex = 26;
            // 
            // textBoxServicesPostalCode
            // 
            this.textBoxServicesPostalCode.Enabled = false;
            this.textBoxServicesPostalCode.Location = new System.Drawing.Point(173, 149);
            this.textBoxServicesPostalCode.Name = "textBoxServicesPostalCode";
            this.textBoxServicesPostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPostalCode.TabIndex = 27;
            // 
            // textBoxServicesPhoneNo
            // 
            this.textBoxServicesPhoneNo.Enabled = false;
            this.textBoxServicesPhoneNo.Location = new System.Drawing.Point(173, 201);
            this.textBoxServicesPhoneNo.Name = "textBoxServicesPhoneNo";
            this.textBoxServicesPhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPhoneNo.TabIndex = 28;
            // 
            // textBoxServicesCity
            // 
            this.textBoxServicesCity.Enabled = false;
            this.textBoxServicesCity.Location = new System.Drawing.Point(173, 175);
            this.textBoxServicesCity.Name = "textBoxServicesCity";
            this.textBoxServicesCity.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesCity.TabIndex = 29;
            // 
            // examinationDescriptionLabel
            // 
            examinationDescriptionLabel.AutoSize = true;
            examinationDescriptionLabel.Location = new System.Drawing.Point(462, 14);
            examinationDescriptionLabel.Name = "examinationDescriptionLabel";
            examinationDescriptionLabel.Size = new System.Drawing.Size(82, 13);
            examinationDescriptionLabel.TabIndex = 43;
            examinationDescriptionLabel.Text = "Wynik Badania:";
            // 
            // textBoxServicesDescription
            // 
            this.textBoxServicesDescription.Location = new System.Drawing.Point(465, 30);
            this.textBoxServicesDescription.Multiline = true;
            this.textBoxServicesDescription.Name = "textBoxServicesDescription";
            this.textBoxServicesDescription.Size = new System.Drawing.Size(724, 592);
            this.textBoxServicesDescription.TabIndex = 50;
            // 
            // buttonSaveExamination
            // 
            this.buttonSaveExamination.Location = new System.Drawing.Point(1105, 628);
            this.buttonSaveExamination.Name = "buttonSaveExamination";
            this.buttonSaveExamination.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveExamination.TabIndex = 51;
            this.buttonSaveExamination.Text = "Zapisz";
            this.buttonSaveExamination.UseVisualStyleBackColor = true;
            this.buttonSaveExamination.Click += new System.EventHandler(this.buttonSaveExamination_Click);
            // 
            // tabVistis
            // 
            this.tabVistis.Controls.Add(this.buttonSaveVisit);
            this.tabVistis.Controls.Add(this.groupBox4);
            this.tabVistis.Controls.Add(this.groupBox3);
            this.tabVistis.Controls.Add(this.groupBox2);
            this.tabVistis.Controls.Add(this.groupBox1);
            this.tabVistis.Location = new System.Drawing.Point(4, 22);
            this.tabVistis.Name = "tabVistis";
            this.tabVistis.Padding = new System.Windows.Forms.Padding(3);
            this.tabVistis.Size = new System.Drawing.Size(1198, 658);
            this.tabVistis.TabIndex = 2;
            this.tabVistis.Text = "Wizyty";
            this.tabVistis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonVisitPatientSearch);
            this.groupBox1.Controls.Add(this.comboBoxVisitDoctor);
            this.groupBox1.Controls.Add(this.dateTimePickerVisitDate);
            this.groupBox1.Controls.Add(medicalSpecialistLabel);
            this.groupBox1.Controls.Add(visitDateLabel);
            this.groupBox1.Controls.Add(label22);
            this.groupBox1.Controls.Add(this.textBoxVisitPesel);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // textBoxVisitPesel
            // 
            this.textBoxVisitPesel.Location = new System.Drawing.Point(129, 40);
            this.textBoxVisitPesel.Name = "textBoxVisitPesel";
            this.textBoxVisitPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPesel.TabIndex = 19;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(6, 43);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(88, 13);
            label22.TabIndex = 22;
            label22.Text = "PESEL pacjenta:";
            // 
            // visitDateLabel
            // 
            visitDateLabel.AutoSize = true;
            visitDateLabel.Location = new System.Drawing.Point(6, 98);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(64, 13);
            visitDateLabel.TabIndex = 21;
            visitDateLabel.Text = "Data wizyty:";
            // 
            // medicalSpecialistLabel
            // 
            medicalSpecialistLabel.AutoSize = true;
            medicalSpecialistLabel.Location = new System.Drawing.Point(6, 69);
            medicalSpecialistLabel.Name = "medicalSpecialistLabel";
            medicalSpecialistLabel.Size = new System.Drawing.Size(102, 13);
            medicalSpecialistLabel.TabIndex = 20;
            medicalSpecialistLabel.Text = "Lekarz prowadzący:";
            // 
            // dateTimePickerVisitDate
            // 
            this.dateTimePickerVisitDate.Location = new System.Drawing.Point(129, 92);
            this.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            this.dateTimePickerVisitDate.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerVisitDate.TabIndex = 25;
            // 
            // comboBoxVisitDoctor
            // 
            this.comboBoxVisitDoctor.FormattingEnabled = true;
            this.comboBoxVisitDoctor.Location = new System.Drawing.Point(129, 66);
            this.comboBoxVisitDoctor.Name = "comboBoxVisitDoctor";
            this.comboBoxVisitDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxVisitDoctor.TabIndex = 46;
            // 
            // buttonVisitPatientSearch
            // 
            this.buttonVisitPatientSearch.Location = new System.Drawing.Point(287, 118);
            this.buttonVisitPatientSearch.Name = "buttonVisitPatientSearch";
            this.buttonVisitPatientSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonVisitPatientSearch.TabIndex = 47;
            this.buttonVisitPatientSearch.Text = "Szukaj";
            this.buttonVisitPatientSearch.UseVisualStyleBackColor = true;
            this.buttonVisitPatientSearch.Click += new System.EventHandler(this.buttonVisitPatientSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxArchivMedicines);
            this.groupBox2.Controls.Add(this.textBoxVisitArchivCode);
            this.groupBox2.Controls.Add(this.textBoxVisitArchiveDescription);
            this.groupBox2.Controls.Add(label12);
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(label13);
            this.groupBox2.Location = new System.Drawing.Point(397, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historia choroby";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 25);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(70, 13);
            label13.TabIndex = 15;
            label13.Text = "Kod choroby:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 54);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 16;
            label9.Text = "Opis:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(8, 260);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(30, 13);
            label12.TabIndex = 17;
            label12.Text = "Leki:";
            // 
            // textBoxVisitArchiveDescription
            // 
            this.textBoxVisitArchiveDescription.Enabled = false;
            this.textBoxVisitArchiveDescription.Location = new System.Drawing.Point(82, 51);
            this.textBoxVisitArchiveDescription.Multiline = true;
            this.textBoxVisitArchiveDescription.Name = "textBoxVisitArchiveDescription";
            this.textBoxVisitArchiveDescription.Size = new System.Drawing.Size(704, 195);
            this.textBoxVisitArchiveDescription.TabIndex = 53;
            // 
            // textBoxVisitArchivCode
            // 
            this.textBoxVisitArchivCode.Enabled = false;
            this.textBoxVisitArchivCode.Location = new System.Drawing.Point(82, 25);
            this.textBoxVisitArchivCode.Name = "textBoxVisitArchivCode";
            this.textBoxVisitArchivCode.Size = new System.Drawing.Size(704, 20);
            this.textBoxVisitArchivCode.TabIndex = 54;
            // 
            // textBoxArchivMedicines
            // 
            this.textBoxArchivMedicines.Enabled = false;
            this.textBoxArchivMedicines.Location = new System.Drawing.Point(82, 257);
            this.textBoxArchivMedicines.Multiline = true;
            this.textBoxArchivMedicines.Name = "textBoxArchivMedicines";
            this.textBoxArchivMedicines.Size = new System.Drawing.Size(704, 96);
            this.textBoxArchivMedicines.TabIndex = 55;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxVisitCity);
            this.groupBox3.Controls.Add(this.textBoxVisitPhoneNo);
            this.groupBox3.Controls.Add(this.textBoxVisitPostalCode);
            this.groupBox3.Controls.Add(this.textBoxVisitStreet);
            this.groupBox3.Controls.Add(this.textBoxVisitStreetNo);
            this.groupBox3.Controls.Add(this.textBoxVisitFirstName);
            this.groupBox3.Controls.Add(this.textBoxVisitLastName);
            this.groupBox3.Controls.Add(label15);
            this.groupBox3.Controls.Add(label16);
            this.groupBox3.Controls.Add(label17);
            this.groupBox3.Controls.Add(label18);
            this.groupBox3.Controls.Add(label19);
            this.groupBox3.Controls.Add(label20);
            this.groupBox3.Controls.Add(label21);
            this.groupBox3.Location = new System.Drawing.Point(9, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane pacjenta";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(6, 226);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(82, 13);
            label21.TabIndex = 21;
            label21.Text = "Numer telefonu:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(6, 200);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(41, 13);
            label20.TabIndex = 20;
            label20.Text = "Miasto:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(6, 174);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(77, 13);
            label19.TabIndex = 19;
            label19.Text = "Kod pocztowy:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(6, 148);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(70, 13);
            label18.TabIndex = 18;
            label18.Text = "Numer domu:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(6, 122);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(34, 13);
            label17.TabIndex = 17;
            label17.Text = "Ulica:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 96);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(56, 13);
            label16.TabIndex = 16;
            label16.Text = "Nazwisko:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 70);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(29, 13);
            label15.TabIndex = 15;
            label15.Text = "Imię:";
            // 
            // textBoxVisitLastName
            // 
            this.textBoxVisitLastName.Enabled = false;
            this.textBoxVisitLastName.Location = new System.Drawing.Point(129, 93);
            this.textBoxVisitLastName.Name = "textBoxVisitLastName";
            this.textBoxVisitLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitLastName.TabIndex = 23;
            // 
            // textBoxVisitFirstName
            // 
            this.textBoxVisitFirstName.Enabled = false;
            this.textBoxVisitFirstName.Location = new System.Drawing.Point(129, 67);
            this.textBoxVisitFirstName.Name = "textBoxVisitFirstName";
            this.textBoxVisitFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitFirstName.TabIndex = 24;
            // 
            // textBoxVisitStreetNo
            // 
            this.textBoxVisitStreetNo.Enabled = false;
            this.textBoxVisitStreetNo.Location = new System.Drawing.Point(129, 145);
            this.textBoxVisitStreetNo.Name = "textBoxVisitStreetNo";
            this.textBoxVisitStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitStreetNo.TabIndex = 25;
            // 
            // textBoxVisitStreet
            // 
            this.textBoxVisitStreet.Enabled = false;
            this.textBoxVisitStreet.Location = new System.Drawing.Point(129, 119);
            this.textBoxVisitStreet.Name = "textBoxVisitStreet";
            this.textBoxVisitStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitStreet.TabIndex = 26;
            // 
            // textBoxVisitPostalCode
            // 
            this.textBoxVisitPostalCode.Enabled = false;
            this.textBoxVisitPostalCode.Location = new System.Drawing.Point(129, 171);
            this.textBoxVisitPostalCode.Name = "textBoxVisitPostalCode";
            this.textBoxVisitPostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPostalCode.TabIndex = 27;
            // 
            // textBoxVisitPhoneNo
            // 
            this.textBoxVisitPhoneNo.Enabled = false;
            this.textBoxVisitPhoneNo.Location = new System.Drawing.Point(129, 223);
            this.textBoxVisitPhoneNo.Name = "textBoxVisitPhoneNo";
            this.textBoxVisitPhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPhoneNo.TabIndex = 28;
            // 
            // textBoxVisitCity
            // 
            this.textBoxVisitCity.Enabled = false;
            this.textBoxVisitCity.Location = new System.Drawing.Point(129, 197);
            this.textBoxVisitCity.Name = "textBoxVisitCity";
            this.textBoxVisitCity.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitCity.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxVisitCode);
            this.groupBox4.Controls.Add(this.textBoxVisitDescription);
            this.groupBox4.Controls.Add(this.buttonMedicines);
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Location = new System.Drawing.Point(397, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 251);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opis wizyty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 27);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 13);
            label8.TabIndex = 9;
            label8.Text = "Kod choroby:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 52);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 13);
            label7.TabIndex = 10;
            label7.Text = "Opis:";
            // 
            // buttonMedicines
            // 
            this.buttonMedicines.Location = new System.Drawing.Point(702, 22);
            this.buttonMedicines.Name = "buttonMedicines";
            this.buttonMedicines.Size = new System.Drawing.Size(84, 23);
            this.buttonMedicines.TabIndex = 50;
            this.buttonMedicines.Text = "Leki";
            this.buttonMedicines.UseVisualStyleBackColor = true;
            // 
            // textBoxVisitDescription
            // 
            this.textBoxVisitDescription.Location = new System.Drawing.Point(82, 50);
            this.textBoxVisitDescription.Multiline = true;
            this.textBoxVisitDescription.Name = "textBoxVisitDescription";
            this.textBoxVisitDescription.Size = new System.Drawing.Size(704, 195);
            this.textBoxVisitDescription.TabIndex = 51;
            // 
            // textBoxVisitCode
            // 
            this.textBoxVisitCode.Location = new System.Drawing.Point(82, 24);
            this.textBoxVisitCode.Name = "textBoxVisitCode";
            this.textBoxVisitCode.Size = new System.Drawing.Size(614, 20);
            this.textBoxVisitCode.TabIndex = 52;
            // 
            // buttonSaveVisit
            // 
            this.buttonSaveVisit.Location = new System.Drawing.Point(1105, 628);
            this.buttonSaveVisit.Name = "buttonSaveVisit";
            this.buttonSaveVisit.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveVisit.TabIndex = 45;
            this.buttonSaveVisit.Text = "Zapisz";
            this.buttonSaveVisit.UseVisualStyleBackColor = true;
            this.buttonSaveVisit.Click += new System.EventHandler(this.buttonSaveVisit_Click);
            // 
            // tabPatients
            // 
            this.tabPatients.AutoScroll = true;
            this.tabPatients.Controls.Add(this.buttonShowArchive);
            this.tabPatients.Controls.Add(this.patientsDataGridView);
            this.tabPatients.Controls.Add(this.buttonDeletePatient);
            this.tabPatients.Controls.Add(this.buttonEditPatient);
            this.tabPatients.Controls.Add(this.buttonAddPatient);
            this.tabPatients.Controls.Add(this.buttonSearch);
            this.tabPatients.Controls.Add(this.label1);
            this.tabPatients.Controls.Add(this.textBoxPatientPesel);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(1198, 658);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Pacjenci";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // textBoxPatientPesel
            // 
            this.textBoxPatientPesel.Location = new System.Drawing.Point(72, 19);
            this.textBoxPatientPesel.Name = "textBoxPatientPesel";
            this.textBoxPatientPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxPatientPesel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "PESEL:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(339, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(1041, 16);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(136, 23);
            this.buttonAddPatient.TabIndex = 21;
            this.buttonAddPatient.Text = "Nowy pacjent";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(899, 622);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(136, 23);
            this.buttonEditPatient.TabIndex = 22;
            this.buttonEditPatient.Text = "Edytuj pacjenta";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(1041, 622);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(136, 23);
            this.buttonDeletePatient.TabIndex = 23;
            this.buttonDeletePatient.Text = "Wypisz pacjenta";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewCheckBoxColumn2});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(16, 61);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.Size = new System.Drawing.Size(1161, 537);
            this.patientsDataGridView.TabIndex = 25;
            // 
            // tabSchedule
            // 
            this.tabSchedule.AutoScroll = true;
            this.tabSchedule.Controls.Add(this.visits_viewDataGridView);
            this.tabSchedule.Controls.Add(this.groupBox10);
            this.tabSchedule.Controls.Add(this.buttonSaveSchedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(1198, 658);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Zapisy na wizyty";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSchedule
            // 
            this.buttonSaveSchedule.Location = new System.Drawing.Point(1105, 628);
            this.buttonSaveSchedule.Name = "buttonSaveSchedule";
            this.buttonSaveSchedule.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveSchedule.TabIndex = 20;
            this.buttonSaveSchedule.Text = "Zapisz";
            this.buttonSaveSchedule.UseVisualStyleBackColor = true;
            this.buttonSaveSchedule.Click += new System.EventHandler(this.buttonSaveSchedule_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.dateTimePicker1);
            this.groupBox10.Controls.Add(this.buttonSearchPatient);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.dateTimePickerScheduler);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.textBoxSchedulerLastName);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.comboBoxSchedulerDoctor);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.textBoxSchedulerFirstName);
            this.groupBox10.Controls.Add(this.textBoxSchedulerPesel);
            this.groupBox10.Location = new System.Drawing.Point(788, 14);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(401, 608);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Zapisy";
            // 
            // textBoxSchedulerPesel
            // 
            this.textBoxSchedulerPesel.Location = new System.Drawing.Point(132, 83);
            this.textBoxSchedulerPesel.Name = "textBoxSchedulerPesel";
            this.textBoxSchedulerPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerPesel.TabIndex = 16;
            // 
            // textBoxSchedulerFirstName
            // 
            this.textBoxSchedulerFirstName.Enabled = false;
            this.textBoxSchedulerFirstName.Location = new System.Drawing.Point(132, 186);
            this.textBoxSchedulerFirstName.Name = "textBoxSchedulerFirstName";
            this.textBoxSchedulerFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerFirstName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imię:";
            // 
            // comboBoxSchedulerDoctor
            // 
            this.comboBoxSchedulerDoctor.FormattingEnabled = true;
            this.comboBoxSchedulerDoctor.Location = new System.Drawing.Point(132, 53);
            this.comboBoxSchedulerDoctor.Name = "comboBoxSchedulerDoctor";
            this.comboBoxSchedulerDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSchedulerDoctor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PESEL:";
            // 
            // textBoxSchedulerLastName
            // 
            this.textBoxSchedulerLastName.Enabled = false;
            this.textBoxSchedulerLastName.Location = new System.Drawing.Point(132, 211);
            this.textBoxSchedulerLastName.Name = "textBoxSchedulerLastName";
            this.textBoxSchedulerLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerLastName.TabIndex = 18;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(39, 267);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "Godzina:";
            // 
            // dateTimePickerScheduler
            // 
            this.dateTimePickerScheduler.Location = new System.Drawing.Point(132, 238);
            this.dateTimePickerScheduler.Name = "dateTimePickerScheduler";
            this.dateTimePickerScheduler.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerScheduler.TabIndex = 24;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(39, 244);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(33, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Data:";
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.Location = new System.Drawing.Point(290, 183);
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Size = new System.Drawing.Size(84, 23);
            this.buttonSearchPatient.TabIndex = 25;
            this.buttonSearchPatient.Text = "Szukaj";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPatients);
            this.tabControl.Controls.Add(this.tabVistis);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Controls.Add(this.tabAdministration);
            this.tabControl.Location = new System.Drawing.Point(-1, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1206, 684);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSaveSchedulerExaminaion);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.exterminations_viewDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1198, 658);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Zapisy na badania";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn14.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nazwisko pacjenta";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nazwisko pacjenta";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Imię pacjenta";
            this.dataGridViewTextBoxColumn12.HeaderText = "Imię pacjenta";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Specjalista";
            this.dataGridViewTextBoxColumn10.HeaderText = "Specjalista";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nazwisko Lekarza";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nazwisko Lekarza";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Imię lekarza";
            this.dataGridViewTextBoxColumn1.HeaderText = "Imię lekarza";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // visits_viewDataGridView
            // 
            this.visits_viewDataGridView.AutoGenerateColumns = false;
            this.visits_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.visits_viewDataGridView.DataSource = this.visits_viewBindingSource;
            this.visits_viewDataGridView.Location = new System.Drawing.Point(12, 14);
            this.visits_viewDataGridView.Name = "visits_viewDataGridView";
            this.visits_viewDataGridView.Size = new System.Drawing.Size(770, 637);
            this.visits_viewDataGridView.TabIndex = 24;
            // 
            // exterminations_viewDataGridView
            // 
            this.exterminations_viewDataGridView.AutoGenerateColumns = false;
            this.exterminations_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exterminations_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.exterminations_viewDataGridView.DataSource = this.exterminations_viewBindingSource;
            this.exterminations_viewDataGridView.Location = new System.Drawing.Point(9, 17);
            this.exterminations_viewDataGridView.Name = "exterminations_viewDataGridView";
            this.exterminations_viewDataGridView.Size = new System.Drawing.Size(770, 621);
            this.exterminations_viewDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Imię";
            this.dataGridViewTextBoxColumn15.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn16.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn17.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Usługa";
            this.dataGridViewTextBoxColumn18.HeaderText = "Usługa";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn19.HeaderText = "Data";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // comboBoxSchedulerService
            // 
            this.comboBoxSchedulerService.FormattingEnabled = true;
            this.comboBoxSchedulerService.Location = new System.Drawing.Point(132, 48);
            this.comboBoxSchedulerService.Name = "comboBoxSchedulerService";
            this.comboBoxSchedulerService.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSchedulerService.TabIndex = 26;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.dateTimePicker2);
            this.groupBox11.Controls.Add(this.comboBoxSchedulerService);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.dateTimePicker3);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.textBox2);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Controls.Add(this.textBox3);
            this.groupBox11.Controls.Add(this.textBox4);
            this.groupBox11.Location = new System.Drawing.Point(785, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(401, 608);
            this.groupBox11.TabIndex = 27;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Zapisy";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 249);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(132, 223);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Godzina:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(132, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "PESEL:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(39, 171);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Imię:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(39, 199);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Nazwisko:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(132, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(39, 56);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 13);
            this.label33.TabIndex = 28;
            this.label33.Text = "Lekarz:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(39, 51);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 13);
            this.label34.TabIndex = 29;
            this.label34.Text = "Nazwa usługi:";
            // 
            // buttonSaveSchedulerExaminaion
            // 
            this.buttonSaveSchedulerExaminaion.Location = new System.Drawing.Point(1102, 629);
            this.buttonSaveSchedulerExaminaion.Name = "buttonSaveSchedulerExaminaion";
            this.buttonSaveSchedulerExaminaion.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveSchedulerExaminaion.TabIndex = 30;
            this.buttonSaveSchedulerExaminaion.Text = "Zapisz";
            this.buttonSaveSchedulerExaminaion.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn21.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn22.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn27.HeaderText = "Numer telefonu";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn28.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "NFZ";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ubezpieczony";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // buttonShowArchive
            // 
            this.buttonShowArchive.Location = new System.Drawing.Point(16, 622);
            this.buttonShowArchive.Name = "buttonShowArchive";
            this.buttonShowArchive.Size = new System.Drawing.Size(136, 23);
            this.buttonShowArchive.TabIndex = 26;
            this.buttonShowArchive.Text = "Pokaż archiwalne";
            this.buttonShowArchive.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1205, 716);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LogoutButton);
            this.MaximumSize = new System.Drawing.Size(1221, 755);
            this.MinimumSize = new System.Drawing.Size(1221, 755);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesBindingSource)).EndInit();
            this.tabAdministration.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesDataGridView)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataGridView)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabVistis.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.tabSchedule.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewDataGridView)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button LogoutButton;
        private DataSet dataSet;
        private DataSetTableAdapters.Employee_viewTableAdapter employee_viewTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource clinicEmployeesBindingSource;
        private DataSetTableAdapters.ClinicEmployeesTableAdapter clinicEmployeesTableAdapter;
        private System.Windows.Forms.BindingSource medicalServicesBindingSource;
        private DataSetTableAdapters.MedicalServicesTableAdapter medicalServicesTableAdapter;
        private System.Windows.Forms.BindingSource visits_viewBindingSource;
        private DataSetTableAdapters.Visits_viewTableAdapter visits_viewTableAdapter;
        private System.Windows.Forms.BindingSource exterminations_viewBindingSource;
        private DataSetTableAdapters.Exterminations_viewTableAdapter exterminations_viewTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.TabPage tabAdministration;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.TextBox textBoxAdministrationServicePrice;
        private System.Windows.Forms.TextBox textBoxAdministrationServiceDescription;
        private System.Windows.Forms.TextBox textBoxAdministrationServiceName;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView medicalServicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button buttonEditService;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView clinicEmployeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEployee;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.Button buttonSaveExamination;
        private System.Windows.Forms.TextBox textBoxServicesDescription;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxServicesCity;
        private System.Windows.Forms.TextBox textBoxServicesPhoneNo;
        private System.Windows.Forms.TextBox textBoxServicesPostalCode;
        private System.Windows.Forms.TextBox textBoxServicesStreet;
        private System.Windows.Forms.TextBox textBoxServicesStreetNo;
        private System.Windows.Forms.TextBox textBoxServicesFirstName;
        private System.Windows.Forms.TextBox textBoxServicesLastName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonServicePatientSearch;
        private System.Windows.Forms.ComboBox comboBoxServicesDoctor;
        private System.Windows.Forms.DateTimePicker dateTimePickerServicesDate;
        private System.Windows.Forms.TextBox textBoxServicesPesel;
        private System.Windows.Forms.ComboBox comboBoxServicesServiceName;
        private System.Windows.Forms.TabPage tabVistis;
        private System.Windows.Forms.Button buttonSaveVisit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxVisitCode;
        private System.Windows.Forms.TextBox textBoxVisitDescription;
        private System.Windows.Forms.Button buttonMedicines;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxVisitCity;
        private System.Windows.Forms.TextBox textBoxVisitPhoneNo;
        private System.Windows.Forms.TextBox textBoxVisitPostalCode;
        private System.Windows.Forms.TextBox textBoxVisitStreet;
        private System.Windows.Forms.TextBox textBoxVisitStreetNo;
        private System.Windows.Forms.TextBox textBoxVisitFirstName;
        private System.Windows.Forms.TextBox textBoxVisitLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxArchivMedicines;
        private System.Windows.Forms.TextBox textBoxVisitArchivCode;
        private System.Windows.Forms.TextBox textBoxVisitArchiveDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonVisitPatientSearch;
        private System.Windows.Forms.ComboBox comboBoxVisitDoctor;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisitDate;
        private System.Windows.Forms.TextBox textBoxVisitPesel;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientPesel;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSearchPatient;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePickerScheduler;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxSchedulerLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSchedulerDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSchedulerFirstName;
        private System.Windows.Forms.TextBox textBoxSchedulerPesel;
        private System.Windows.Forms.Button buttonSaveSchedule;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView visits_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBoxSchedulerService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView exterminations_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button buttonSaveSchedulerExaminaion;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button buttonShowArchive;
    }
}

