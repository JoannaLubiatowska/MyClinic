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
            System.Windows.Forms.Label label35;
            System.Windows.Forms.Label label36;
            System.Windows.Forms.Label label37;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label label38;
            this.label11 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.tabAdministration = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.textBoxAdministrationServicePrice = new System.Windows.Forms.TextBox();
            this.textBoxAdministrationServiceDescription = new System.Windows.Forms.TextBox();
            this.textBoxAdministrationServiceName = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.medicalServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MyClinic.DataSet();
            this.buttonEditService = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.clinicEmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clinicEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEployee = new System.Windows.Forms.Button();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.buttonSaveExamination = new System.Windows.Forms.Button();
            this.textBoxServicesDescription = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxServicesCity = new System.Windows.Forms.TextBox();
            this.textBoxServicesPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxServicesPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxServicesStreet = new System.Windows.Forms.TextBox();
            this.textBoxServicesStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxServicesFirstName = new System.Windows.Forms.TextBox();
            this.textBoxServicesLastName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonServicePatientSearch = new System.Windows.Forms.Button();
            this.comboBoxServicesDoctor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerServicesDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxServicesPesel = new System.Windows.Forms.TextBox();
            this.comboBoxServicesServiceName = new System.Windows.Forms.ComboBox();
            this.tabVistis = new System.Windows.Forms.TabPage();
            this.visitBasics_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitBasics_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSaveVisit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectMedicines = new System.Windows.Forms.ComboBox();
            this.textBoxVisitCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxVisitCity = new System.Windows.Forms.TextBox();
            this.textBoxVisitPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxVisitPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitStreet = new System.Windows.Forms.TextBox();
            this.textBoxVisitStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxVisitFirstName = new System.Windows.Forms.TextBox();
            this.textBoxVisitLastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxArchivMedicines = new System.Windows.Forms.TextBox();
            this.textBoxVisitArchivCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitArchiveDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonVisitPatientSearch = new System.Windows.Forms.Button();
            this.comboBoxVisitDoctor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVisitDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxVisitPesel = new System.Windows.Forms.TextBox();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.checkBoxArchive = new System.Windows.Forms.CheckBox();
            this.patients_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patients_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientPesel = new System.Windows.Forms.TextBox();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.visits_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visits_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dateTimePickerSchedulerVisitsHours = new System.Windows.Forms.DateTimePicker();
            this.buttonSearchPatient = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePickerSchedulerVisit = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxSchedulerLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSchedulerDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSchedulerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSchedulerPesel = new System.Windows.Forms.TextBox();
            this.buttonSaveSchedule = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSaveSchedulerExaminaion = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.dateTimePickerHouersSchedulerExamination = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSchedulerService = new System.Windows.Forms.ComboBox();
            this.buttonSearchPeselSchedulerExamination = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDateSchedulerExamination = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLastNameSchedulerExamination = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.textBoxFirstNameSchedulerExamination = new System.Windows.Forms.TextBox();
            this.textBoxPeselSchedulerExamination = new System.Windows.Forms.TextBox();
            this.exterminations_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exterminations_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.countByMonthviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.countvisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countVisitByMonthviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_viewTableAdapter = new MyClinic.DataSetTableAdapters.Employee_viewTableAdapter();
            this.tableAdapterManager = new MyClinic.DataSetTableAdapters.TableAdapterManager();
            this.clinicEmployeesTableAdapter = new MyClinic.DataSetTableAdapters.ClinicEmployeesTableAdapter();
            this.medicalServicesTableAdapter = new MyClinic.DataSetTableAdapters.MedicalServicesTableAdapter();
            this.visits_viewTableAdapter = new MyClinic.DataSetTableAdapters.Visits_viewTableAdapter();
            this.exterminations_viewTableAdapter = new MyClinic.DataSetTableAdapters.Exterminations_viewTableAdapter();
            this.patientsTableAdapter = new MyClinic.DataSetTableAdapters.PatientsTableAdapter();
            this.patients_viewTableAdapter = new MyClinic.DataSetTableAdapters.Patients_viewTableAdapter();
            this.count_visitsTableAdapter = new MyClinic.DataSetTableAdapters.count_visitsTableAdapter();
            this.countVisitByMonth_viewTableAdapter = new MyClinic.DataSetTableAdapters.CountVisitByMonth_viewTableAdapter();
            this.countByMonth_viewTableAdapter = new MyClinic.DataSetTableAdapters.CountByMonth_viewTableAdapter();
            this.visitBasics_viewTableAdapter = new MyClinic.DataSetTableAdapters.VisitBasics_viewTableAdapter();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
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
            label35 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label38 = new System.Windows.Forms.Label();
            this.tabAdministration.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesBindingSource)).BeginInit();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabVistis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBasics_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBasics_viewBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewBindingSource)).BeginInit();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewBindingSource)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countByMonthviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countvisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVisitByMonthviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // examinationDateLabel
            // 
            examinationDateLabel.AutoSize = true;
            examinationDateLabel.Location = new System.Drawing.Point(6, 103);
            examinationDateLabel.Name = "examinationDateLabel";
            examinationDateLabel.Size = new System.Drawing.Size(128, 13);
            examinationDateLabel.TabIndex = 43;
            examinationDateLabel.Text = "Data wykonania badania:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(6, 74);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(88, 13);
            patientIDLabel.TabIndex = 41;
            patientIDLabel.Text = "PESEL pacjenta:";
            // 
            // medicalServiceIDLabel
            // 
            medicalServiceIDLabel.AutoSize = true;
            medicalServiceIDLabel.Location = new System.Drawing.Point(6, 48);
            medicalServiceIDLabel.Name = "medicalServiceIDLabel";
            medicalServiceIDLabel.Size = new System.Drawing.Size(75, 13);
            medicalServiceIDLabel.TabIndex = 40;
            medicalServiceIDLabel.Text = "Nazwa usługi:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(6, 22);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(142, 13);
            employeeIDLabel.TabIndex = 39;
            employeeIDLabel.Text = "Osoba wykonująca badanie:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(6, 178);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(82, 13);
            label28.TabIndex = 21;
            label28.Text = "Numer telefonu:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(6, 152);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(41, 13);
            label27.TabIndex = 20;
            label27.Text = "Miasto:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(6, 126);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(77, 13);
            label26.TabIndex = 19;
            label26.Text = "Kod pocztowy:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(6, 100);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(70, 13);
            label25.TabIndex = 18;
            label25.Text = "Numer domu:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(6, 74);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(34, 13);
            label24.TabIndex = 17;
            label24.Text = "Ulica:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(6, 48);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(56, 13);
            label23.TabIndex = 16;
            label23.Text = "Nazwisko:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 22);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 13);
            label14.TabIndex = 15;
            label14.Text = "Imię:";
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
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(6, 21);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(88, 13);
            label22.TabIndex = 22;
            label22.Text = "PESEL pacjenta:";
            // 
            // visitDateLabel
            // 
            visitDateLabel.AutoSize = true;
            visitDateLabel.Location = new System.Drawing.Point(6, 73);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(64, 13);
            visitDateLabel.TabIndex = 21;
            visitDateLabel.Text = "Data wizyty:";
            // 
            // medicalSpecialistLabel
            // 
            medicalSpecialistLabel.AutoSize = true;
            medicalSpecialistLabel.Location = new System.Drawing.Point(6, 45);
            medicalSpecialistLabel.Name = "medicalSpecialistLabel";
            medicalSpecialistLabel.Size = new System.Drawing.Size(61, 13);
            medicalSpecialistLabel.TabIndex = 20;
            medicalSpecialistLabel.Text = "Specjalista:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(8, 21);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(70, 13);
            label13.TabIndex = 15;
            label13.Text = "Kod choroby:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 50);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 16;
            label9.Text = "Opis:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(10, 235);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(30, 13);
            label12.TabIndex = 17;
            label12.Text = "Leki:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(6, 205);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(82, 13);
            label21.TabIndex = 21;
            label21.Text = "Numer telefonu:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(6, 179);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(41, 13);
            label20.TabIndex = 20;
            label20.Text = "Miasto:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(6, 153);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(77, 13);
            label19.TabIndex = 19;
            label19.Text = "Kod pocztowy:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(6, 127);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(70, 13);
            label18.TabIndex = 18;
            label18.Text = "Numer domu:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(6, 101);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(34, 13);
            label17.TabIndex = 17;
            label17.Text = "Ulica:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 48);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(56, 13);
            label16.TabIndex = 16;
            label16.Text = "Nazwisko:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 22);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(29, 13);
            label15.TabIndex = 15;
            label15.Text = "Imię:";
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
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new System.Drawing.Point(8, 240);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(54, 13);
            label35.TabIndex = 53;
            label35.Text = "Nowy lek:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new System.Drawing.Point(15, 383);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(55, 13);
            label36.TabIndex = 30;
            label36.Text = "Na dzisiaj:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new System.Drawing.Point(9, 355);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(55, 13);
            label37.TabIndex = 54;
            label37.Text = "Na dzisiaj:";
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
            // textBoxAdministrationServicePrice
            // 
            this.textBoxAdministrationServicePrice.Location = new System.Drawing.Point(98, 125);
            this.textBoxAdministrationServicePrice.Name = "textBoxAdministrationServicePrice";
            this.textBoxAdministrationServicePrice.Size = new System.Drawing.Size(342, 20);
            this.textBoxAdministrationServicePrice.TabIndex = 26;
            // 
            // textBoxAdministrationServiceDescription
            // 
            this.textBoxAdministrationServiceDescription.Location = new System.Drawing.Point(98, 51);
            this.textBoxAdministrationServiceDescription.Multiline = true;
            this.textBoxAdministrationServiceDescription.Name = "textBoxAdministrationServiceDescription";
            this.textBoxAdministrationServiceDescription.Size = new System.Drawing.Size(342, 68);
            this.textBoxAdministrationServiceDescription.TabIndex = 25;
            // 
            // textBoxAdministrationServiceName
            // 
            this.textBoxAdministrationServiceName.Location = new System.Drawing.Point(98, 25);
            this.textBoxAdministrationServiceName.Name = "textBoxAdministrationServiceName";
            this.textBoxAdministrationServiceName.Size = new System.Drawing.Size(342, 20);
            this.textBoxAdministrationServiceName.TabIndex = 21;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Usluga";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ServiceDescription";
            this.dataGridViewTextBoxColumn5.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // medicalServicesBindingSource
            // 
            this.medicalServicesBindingSource.DataMember = "MedicalServices";
            this.medicalServicesBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Numer telefonu";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EmployeeDescription";
            this.dataGridViewTextBoxColumn9.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Zatrudniony";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // clinicEmployeesBindingSource
            // 
            this.clinicEmployeesBindingSource.DataMember = "ClinicEmployees";
            this.clinicEmployeesBindingSource.DataSource = this.dataSet;
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
            // tabServices
            // 
            this.tabServices.Controls.Add(label36);
            this.tabServices.Controls.Add(this.dataGridViewServices);
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
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(9, 399);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.Size = new System.Drawing.Size(440, 223);
            this.dataGridViewServices.TabIndex = 52;
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
            // textBoxServicesDescription
            // 
            this.textBoxServicesDescription.Location = new System.Drawing.Point(465, 30);
            this.textBoxServicesDescription.Multiline = true;
            this.textBoxServicesDescription.Name = "textBoxServicesDescription";
            this.textBoxServicesDescription.Size = new System.Drawing.Size(724, 592);
            this.textBoxServicesDescription.TabIndex = 50;
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
            this.groupBox6.Location = new System.Drawing.Point(9, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(440, 207);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dane pacjenta";
            // 
            // textBoxServicesCity
            // 
            this.textBoxServicesCity.Enabled = false;
            this.textBoxServicesCity.Location = new System.Drawing.Point(173, 149);
            this.textBoxServicesCity.Name = "textBoxServicesCity";
            this.textBoxServicesCity.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesCity.TabIndex = 29;
            // 
            // textBoxServicesPhoneNo
            // 
            this.textBoxServicesPhoneNo.Enabled = false;
            this.textBoxServicesPhoneNo.Location = new System.Drawing.Point(173, 175);
            this.textBoxServicesPhoneNo.Name = "textBoxServicesPhoneNo";
            this.textBoxServicesPhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPhoneNo.TabIndex = 28;
            // 
            // textBoxServicesPostalCode
            // 
            this.textBoxServicesPostalCode.Enabled = false;
            this.textBoxServicesPostalCode.Location = new System.Drawing.Point(173, 123);
            this.textBoxServicesPostalCode.Name = "textBoxServicesPostalCode";
            this.textBoxServicesPostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPostalCode.TabIndex = 27;
            // 
            // textBoxServicesStreet
            // 
            this.textBoxServicesStreet.Enabled = false;
            this.textBoxServicesStreet.Location = new System.Drawing.Point(173, 71);
            this.textBoxServicesStreet.Name = "textBoxServicesStreet";
            this.textBoxServicesStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesStreet.TabIndex = 26;
            // 
            // textBoxServicesStreetNo
            // 
            this.textBoxServicesStreetNo.Enabled = false;
            this.textBoxServicesStreetNo.Location = new System.Drawing.Point(173, 97);
            this.textBoxServicesStreetNo.Name = "textBoxServicesStreetNo";
            this.textBoxServicesStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesStreetNo.TabIndex = 25;
            // 
            // textBoxServicesFirstName
            // 
            this.textBoxServicesFirstName.Enabled = false;
            this.textBoxServicesFirstName.Location = new System.Drawing.Point(173, 19);
            this.textBoxServicesFirstName.Name = "textBoxServicesFirstName";
            this.textBoxServicesFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesFirstName.TabIndex = 24;
            // 
            // textBoxServicesLastName
            // 
            this.textBoxServicesLastName.Enabled = false;
            this.textBoxServicesLastName.Location = new System.Drawing.Point(173, 45);
            this.textBoxServicesLastName.Name = "textBoxServicesLastName";
            this.textBoxServicesLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesLastName.TabIndex = 23;
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
            this.groupBox5.Size = new System.Drawing.Size(440, 157);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Szczegóły";
            // 
            // buttonServicePatientSearch
            // 
            this.buttonServicePatientSearch.Location = new System.Drawing.Point(331, 123);
            this.buttonServicePatientSearch.Name = "buttonServicePatientSearch";
            this.buttonServicePatientSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonServicePatientSearch.TabIndex = 50;
            this.buttonServicePatientSearch.Text = "Szukaj";
            this.buttonServicePatientSearch.UseVisualStyleBackColor = true;
            this.buttonServicePatientSearch.Click += new System.EventHandler(this.buttonServicePatientSearch_Click);
            // 
            // comboBoxServicesDoctor
            // 
            this.comboBoxServicesDoctor.FormattingEnabled = true;
            this.comboBoxServicesDoctor.Location = new System.Drawing.Point(173, 19);
            this.comboBoxServicesDoctor.Name = "comboBoxServicesDoctor";
            this.comboBoxServicesDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxServicesDoctor.TabIndex = 49;
            // 
            // dateTimePickerServicesDate
            // 
            this.dateTimePickerServicesDate.Location = new System.Drawing.Point(173, 97);
            this.dateTimePickerServicesDate.Name = "dateTimePickerServicesDate";
            this.dateTimePickerServicesDate.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerServicesDate.TabIndex = 48;
            // 
            // textBoxServicesPesel
            // 
            this.textBoxServicesPesel.Location = new System.Drawing.Point(173, 71);
            this.textBoxServicesPesel.Name = "textBoxServicesPesel";
            this.textBoxServicesPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPesel.TabIndex = 46;
            // 
            // comboBoxServicesServiceName
            // 
            this.comboBoxServicesServiceName.FormattingEnabled = true;
            this.comboBoxServicesServiceName.Location = new System.Drawing.Point(173, 45);
            this.comboBoxServicesServiceName.Name = "comboBoxServicesServiceName";
            this.comboBoxServicesServiceName.Size = new System.Drawing.Size(242, 21);
            this.comboBoxServicesServiceName.TabIndex = 45;
            // 
            // tabVistis
            // 
            this.tabVistis.AutoScroll = true;
            this.tabVistis.Controls.Add(this.visitBasics_viewDataGridView);
            this.tabVistis.Controls.Add(label37);
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
            // visitBasics_viewDataGridView
            // 
            this.visitBasics_viewDataGridView.AutoGenerateColumns = false;
            this.visitBasics_viewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visitBasics_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitBasics_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn34});
            this.visitBasics_viewDataGridView.DataSource = this.visitBasics_viewBindingSource;
            this.visitBasics_viewDataGridView.Location = new System.Drawing.Point(9, 371);
            this.visitBasics_viewDataGridView.Name = "visitBasics_viewDataGridView";
            this.visitBasics_viewDataGridView.Size = new System.Drawing.Size(407, 251);
            this.visitBasics_viewDataGridView.TabIndex = 54;
            this.visitBasics_viewDataGridView.SelectionChanged += new System.EventHandler(this.visitBasics_viewDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn30.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn31.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "VisitDate";
            this.dataGridViewTextBoxColumn34.HeaderText = "VisitDate";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // visitBasics_viewBindingSource
            // 
            this.visitBasics_viewBindingSource.DataMember = "VisitBasics_view";
            this.visitBasics_viewBindingSource.DataSource = this.dataSet;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSelectMedicines);
            this.groupBox4.Controls.Add(label35);
            this.groupBox4.Controls.Add(this.textBoxVisitCode);
            this.groupBox4.Controls.Add(this.textBoxVisitDescription);
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Location = new System.Drawing.Point(422, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(767, 264);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opis wizyty";
            // 
            // comboBoxSelectMedicines
            // 
            this.comboBoxSelectMedicines.FormattingEnabled = true;
            this.comboBoxSelectMedicines.Location = new System.Drawing.Point(82, 235);
            this.comboBoxSelectMedicines.Name = "comboBoxSelectMedicines";
            this.comboBoxSelectMedicines.Size = new System.Drawing.Size(669, 21);
            this.comboBoxSelectMedicines.TabIndex = 54;
            // 
            // textBoxVisitCode
            // 
            this.textBoxVisitCode.Location = new System.Drawing.Point(82, 24);
            this.textBoxVisitCode.Name = "textBoxVisitCode";
            this.textBoxVisitCode.Size = new System.Drawing.Size(669, 20);
            this.textBoxVisitCode.TabIndex = 52;
            // 
            // textBoxVisitDescription
            // 
            this.textBoxVisitDescription.Location = new System.Drawing.Point(82, 50);
            this.textBoxVisitDescription.Multiline = true;
            this.textBoxVisitDescription.Name = "textBoxVisitDescription";
            this.textBoxVisitDescription.Size = new System.Drawing.Size(669, 179);
            this.textBoxVisitDescription.TabIndex = 51;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label38);
            this.groupBox3.Controls.Add(this.textBoxPesel);
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
            this.groupBox3.Location = new System.Drawing.Point(9, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane pacjenta";
            // 
            // textBoxVisitCity
            // 
            this.textBoxVisitCity.Enabled = false;
            this.textBoxVisitCity.Location = new System.Drawing.Point(129, 176);
            this.textBoxVisitCity.Name = "textBoxVisitCity";
            this.textBoxVisitCity.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitCity.TabIndex = 29;
            // 
            // textBoxVisitPhoneNo
            // 
            this.textBoxVisitPhoneNo.Enabled = false;
            this.textBoxVisitPhoneNo.Location = new System.Drawing.Point(129, 202);
            this.textBoxVisitPhoneNo.Name = "textBoxVisitPhoneNo";
            this.textBoxVisitPhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPhoneNo.TabIndex = 28;
            // 
            // textBoxVisitPostalCode
            // 
            this.textBoxVisitPostalCode.Enabled = false;
            this.textBoxVisitPostalCode.Location = new System.Drawing.Point(129, 150);
            this.textBoxVisitPostalCode.Name = "textBoxVisitPostalCode";
            this.textBoxVisitPostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPostalCode.TabIndex = 27;
            // 
            // textBoxVisitStreet
            // 
            this.textBoxVisitStreet.Enabled = false;
            this.textBoxVisitStreet.Location = new System.Drawing.Point(129, 98);
            this.textBoxVisitStreet.Name = "textBoxVisitStreet";
            this.textBoxVisitStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitStreet.TabIndex = 26;
            // 
            // textBoxVisitStreetNo
            // 
            this.textBoxVisitStreetNo.Enabled = false;
            this.textBoxVisitStreetNo.Location = new System.Drawing.Point(129, 124);
            this.textBoxVisitStreetNo.Name = "textBoxVisitStreetNo";
            this.textBoxVisitStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitStreetNo.TabIndex = 25;
            // 
            // textBoxVisitFirstName
            // 
            this.textBoxVisitFirstName.Enabled = false;
            this.textBoxVisitFirstName.Location = new System.Drawing.Point(129, 19);
            this.textBoxVisitFirstName.Name = "textBoxVisitFirstName";
            this.textBoxVisitFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitFirstName.TabIndex = 24;
            // 
            // textBoxVisitLastName
            // 
            this.textBoxVisitLastName.Enabled = false;
            this.textBoxVisitLastName.Location = new System.Drawing.Point(129, 45);
            this.textBoxVisitLastName.Name = "textBoxVisitLastName";
            this.textBoxVisitLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitLastName.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxArchivMedicines);
            this.groupBox2.Controls.Add(this.textBoxVisitArchivCode);
            this.groupBox2.Controls.Add(this.textBoxVisitArchiveDescription);
            this.groupBox2.Controls.Add(label12);
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(label13);
            this.groupBox2.Location = new System.Drawing.Point(422, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historia choroby";
            // 
            // textBoxArchivMedicines
            // 
            this.textBoxArchivMedicines.Enabled = false;
            this.textBoxArchivMedicines.Location = new System.Drawing.Point(82, 236);
            this.textBoxArchivMedicines.Multiline = true;
            this.textBoxArchivMedicines.Name = "textBoxArchivMedicines";
            this.textBoxArchivMedicines.Size = new System.Drawing.Size(669, 96);
            this.textBoxArchivMedicines.TabIndex = 55;
            // 
            // textBoxVisitArchivCode
            // 
            this.textBoxVisitArchivCode.Enabled = false;
            this.textBoxVisitArchivCode.Location = new System.Drawing.Point(82, 25);
            this.textBoxVisitArchivCode.Name = "textBoxVisitArchivCode";
            this.textBoxVisitArchivCode.Size = new System.Drawing.Size(669, 20);
            this.textBoxVisitArchivCode.TabIndex = 54;
            // 
            // textBoxVisitArchiveDescription
            // 
            this.textBoxVisitArchiveDescription.Enabled = false;
            this.textBoxVisitArchiveDescription.Location = new System.Drawing.Point(82, 51);
            this.textBoxVisitArchiveDescription.Multiline = true;
            this.textBoxVisitArchiveDescription.Name = "textBoxVisitArchiveDescription";
            this.textBoxVisitArchiveDescription.Size = new System.Drawing.Size(669, 179);
            this.textBoxVisitArchiveDescription.TabIndex = 53;
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
            this.groupBox1.Size = new System.Drawing.Size(407, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // buttonVisitPatientSearch
            // 
            this.buttonVisitPatientSearch.Location = new System.Drawing.Point(287, 89);
            this.buttonVisitPatientSearch.Name = "buttonVisitPatientSearch";
            this.buttonVisitPatientSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonVisitPatientSearch.TabIndex = 47;
            this.buttonVisitPatientSearch.Text = "Szukaj";
            this.buttonVisitPatientSearch.UseVisualStyleBackColor = true;
            this.buttonVisitPatientSearch.Click += new System.EventHandler(this.buttonVisitPatientSearch_Click);
            // 
            // comboBoxVisitDoctor
            // 
            this.comboBoxVisitDoctor.FormattingEnabled = true;
            this.comboBoxVisitDoctor.Location = new System.Drawing.Point(129, 42);
            this.comboBoxVisitDoctor.Name = "comboBoxVisitDoctor";
            this.comboBoxVisitDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxVisitDoctor.TabIndex = 46;
            // 
            // dateTimePickerVisitDate
            // 
            this.dateTimePickerVisitDate.Enabled = false;
            this.dateTimePickerVisitDate.Location = new System.Drawing.Point(129, 67);
            this.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            this.dateTimePickerVisitDate.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerVisitDate.TabIndex = 25;
            // 
            // textBoxVisitPesel
            // 
            this.textBoxVisitPesel.Location = new System.Drawing.Point(129, 18);
            this.textBoxVisitPesel.Name = "textBoxVisitPesel";
            this.textBoxVisitPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPesel.TabIndex = 19;
            // 
            // tabPatients
            // 
            this.tabPatients.AutoScroll = true;
            this.tabPatients.Controls.Add(this.checkBoxArchive);
            this.tabPatients.Controls.Add(this.patients_viewDataGridView);
            this.tabPatients.Controls.Add(this.buttonDeletePatient);
            this.tabPatients.Controls.Add(this.buttonEditPatient);
            this.tabPatients.Controls.Add(this.buttonAddPatient);
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
            // checkBoxArchive
            // 
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.Location = new System.Drawing.Point(20, 622);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.Size = new System.Drawing.Size(78, 17);
            this.checkBoxArchive.TabIndex = 27;
            this.checkBoxArchive.Text = "Archiwalne";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            this.checkBoxArchive.CheckedChanged += new System.EventHandler(this.checkBoxArchive_CheckedChanged);
            // 
            // patients_viewDataGridView
            // 
            this.patients_viewDataGridView.AutoGenerateColumns = false;
            this.patients_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewCheckBoxColumn2});
            this.patients_viewDataGridView.DataSource = this.patients_viewBindingSource;
            this.patients_viewDataGridView.Location = new System.Drawing.Point(20, 56);
            this.patients_viewDataGridView.Name = "patients_viewDataGridView";
            this.patients_viewDataGridView.Size = new System.Drawing.Size(1157, 550);
            this.patients_viewDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Imię";
            this.dataGridViewTextBoxColumn20.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn21.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn22.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Numer telefonu";
            this.dataGridViewTextBoxColumn23.HeaderText = "Numer telefonu";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Ulica";
            this.dataGridViewTextBoxColumn24.HeaderText = "Ulica";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Numer";
            this.dataGridViewTextBoxColumn25.HeaderText = "Numer";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Kod pocztowy";
            this.dataGridViewTextBoxColumn26.HeaderText = "Kod pocztowy";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Miasto";
            this.dataGridViewTextBoxColumn27.HeaderText = "Miasto";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Województwo";
            this.dataGridViewTextBoxColumn28.HeaderText = "Województwo";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Zapisany";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Zapisany";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // patients_viewBindingSource
            // 
            this.patients_viewBindingSource.DataMember = "Patients_view";
            this.patients_viewBindingSource.DataSource = this.dataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "PESEL:";
            // 
            // textBoxPatientPesel
            // 
            this.textBoxPatientPesel.Location = new System.Drawing.Point(81, 19);
            this.textBoxPatientPesel.Name = "textBoxPatientPesel";
            this.textBoxPatientPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxPatientPesel.TabIndex = 18;
            this.textBoxPatientPesel.TextChanged += new System.EventHandler(this.textBoxPatientPesel_TextChanged);
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
            // visits_viewDataGridView
            // 
            this.visits_viewDataGridView.AutoGenerateColumns = false;
            this.visits_viewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.visits_viewDataGridView.Size = new System.Drawing.Size(770, 608);
            this.visits_viewDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Imię lekarza";
            this.dataGridViewTextBoxColumn1.HeaderText = "Imię lekarza";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nazwisko Lekarza";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nazwisko Lekarza";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Specjalista";
            this.dataGridViewTextBoxColumn10.HeaderText = "Specjalista";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Imię pacjenta";
            this.dataGridViewTextBoxColumn12.HeaderText = "Imię pacjenta";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nazwisko pacjenta";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nazwisko pacjenta";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn14.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // visits_viewBindingSource
            // 
            this.visits_viewBindingSource.DataMember = "Visits_view";
            this.visits_viewBindingSource.DataSource = this.dataSet;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.dateTimePickerSchedulerVisitsHours);
            this.groupBox10.Controls.Add(this.buttonSearchPatient);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.dateTimePickerSchedulerVisit);
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
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(39, 56);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 13);
            this.label33.TabIndex = 28;
            this.label33.Text = "Lekarz:";
            // 
            // dateTimePickerSchedulerVisitsHours
            // 
            this.dateTimePickerSchedulerVisitsHours.CustomFormat = "hh:mm";
            this.dateTimePickerSchedulerVisitsHours.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSchedulerVisitsHours.Location = new System.Drawing.Point(132, 264);
            this.dateTimePickerSchedulerVisitsHours.Name = "dateTimePickerSchedulerVisitsHours";
            this.dateTimePickerSchedulerVisitsHours.ShowUpDown = true;
            this.dateTimePickerSchedulerVisitsHours.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerSchedulerVisitsHours.TabIndex = 27;
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.Location = new System.Drawing.Point(290, 165);
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Size = new System.Drawing.Size(84, 23);
            this.buttonSearchPatient.TabIndex = 25;
            this.buttonSearchPatient.Text = "Szukaj";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
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
            // dateTimePickerSchedulerVisit
            // 
            this.dateTimePickerSchedulerVisit.Location = new System.Drawing.Point(132, 238);
            this.dateTimePickerSchedulerVisit.Name = "dateTimePickerSchedulerVisit";
            this.dateTimePickerSchedulerVisit.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerSchedulerVisit.TabIndex = 24;
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
            // textBoxSchedulerLastName
            // 
            this.textBoxSchedulerLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSchedulerLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSchedulerLastName.Location = new System.Drawing.Point(132, 139);
            this.textBoxSchedulerLastName.Name = "textBoxSchedulerLastName";
            this.textBoxSchedulerLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerLastName.TabIndex = 18;
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
            // comboBoxSchedulerDoctor
            // 
            this.comboBoxSchedulerDoctor.FormattingEnabled = true;
            this.comboBoxSchedulerDoctor.Location = new System.Drawing.Point(132, 53);
            this.comboBoxSchedulerDoctor.Name = "comboBoxSchedulerDoctor";
            this.comboBoxSchedulerDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSchedulerDoctor.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imię:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nazwisko:";
            // 
            // textBoxSchedulerFirstName
            // 
            this.textBoxSchedulerFirstName.Location = new System.Drawing.Point(132, 113);
            this.textBoxSchedulerFirstName.Name = "textBoxSchedulerFirstName";
            this.textBoxSchedulerFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerFirstName.TabIndex = 17;
            // 
            // textBoxSchedulerPesel
            // 
            this.textBoxSchedulerPesel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSchedulerPesel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSchedulerPesel.Location = new System.Drawing.Point(132, 83);
            this.textBoxSchedulerPesel.Name = "textBoxSchedulerPesel";
            this.textBoxSchedulerPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerPesel.TabIndex = 16;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPatients);
            this.tabControl.Controls.Add(this.tabVistis);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Controls.Add(this.tabAdministration);
            this.tabControl.Controls.Add(this.tabPage2);
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
            // buttonSaveSchedulerExaminaion
            // 
            this.buttonSaveSchedulerExaminaion.Location = new System.Drawing.Point(1102, 629);
            this.buttonSaveSchedulerExaminaion.Name = "buttonSaveSchedulerExaminaion";
            this.buttonSaveSchedulerExaminaion.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveSchedulerExaminaion.TabIndex = 30;
            this.buttonSaveSchedulerExaminaion.Text = "Zapisz";
            this.buttonSaveSchedulerExaminaion.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.dateTimePickerHouersSchedulerExamination);
            this.groupBox11.Controls.Add(this.comboBoxSchedulerService);
            this.groupBox11.Controls.Add(this.buttonSearchPeselSchedulerExamination);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.dateTimePickerDateSchedulerExamination);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.textBoxLastNameSchedulerExamination);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Controls.Add(this.textBoxFirstNameSchedulerExamination);
            this.groupBox11.Controls.Add(this.textBoxPeselSchedulerExamination);
            this.groupBox11.Location = new System.Drawing.Point(785, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(401, 608);
            this.groupBox11.TabIndex = 27;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Zapisy";
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
            // dateTimePickerHouersSchedulerExamination
            // 
            this.dateTimePickerHouersSchedulerExamination.CustomFormat = "hh:mm";
            this.dateTimePickerHouersSchedulerExamination.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHouersSchedulerExamination.Location = new System.Drawing.Point(132, 249);
            this.dateTimePickerHouersSchedulerExamination.Name = "dateTimePickerHouersSchedulerExamination";
            this.dateTimePickerHouersSchedulerExamination.ShowUpDown = true;
            this.dateTimePickerHouersSchedulerExamination.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerHouersSchedulerExamination.TabIndex = 27;
            // 
            // comboBoxSchedulerService
            // 
            this.comboBoxSchedulerService.FormattingEnabled = true;
            this.comboBoxSchedulerService.Location = new System.Drawing.Point(132, 48);
            this.comboBoxSchedulerService.Name = "comboBoxSchedulerService";
            this.comboBoxSchedulerService.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSchedulerService.TabIndex = 26;
            // 
            // buttonSearchPeselSchedulerExamination
            // 
            this.buttonSearchPeselSchedulerExamination.Location = new System.Drawing.Point(290, 158);
            this.buttonSearchPeselSchedulerExamination.Name = "buttonSearchPeselSchedulerExamination";
            this.buttonSearchPeselSchedulerExamination.Size = new System.Drawing.Size(84, 23);
            this.buttonSearchPeselSchedulerExamination.TabIndex = 25;
            this.buttonSearchPeselSchedulerExamination.Text = "Szukaj";
            this.buttonSearchPeselSchedulerExamination.UseVisualStyleBackColor = true;
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
            // dateTimePickerDateSchedulerExamination
            // 
            this.dateTimePickerDateSchedulerExamination.Location = new System.Drawing.Point(132, 223);
            this.dateTimePickerDateSchedulerExamination.Name = "dateTimePickerDateSchedulerExamination";
            this.dateTimePickerDateSchedulerExamination.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerDateSchedulerExamination.TabIndex = 24;
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
            // textBoxLastNameSchedulerExamination
            // 
            this.textBoxLastNameSchedulerExamination.Location = new System.Drawing.Point(132, 132);
            this.textBoxLastNameSchedulerExamination.Name = "textBoxLastNameSchedulerExamination";
            this.textBoxLastNameSchedulerExamination.Size = new System.Drawing.Size(242, 20);
            this.textBoxLastNameSchedulerExamination.TabIndex = 18;
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
            this.label31.Location = new System.Drawing.Point(39, 106);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Imię:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(39, 135);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Nazwisko:";
            // 
            // textBoxFirstNameSchedulerExamination
            // 
            this.textBoxFirstNameSchedulerExamination.Location = new System.Drawing.Point(132, 106);
            this.textBoxFirstNameSchedulerExamination.Name = "textBoxFirstNameSchedulerExamination";
            this.textBoxFirstNameSchedulerExamination.Size = new System.Drawing.Size(242, 20);
            this.textBoxFirstNameSchedulerExamination.TabIndex = 17;
            // 
            // textBoxPeselSchedulerExamination
            // 
            this.textBoxPeselSchedulerExamination.Location = new System.Drawing.Point(132, 77);
            this.textBoxPeselSchedulerExamination.Name = "textBoxPeselSchedulerExamination";
            this.textBoxPeselSchedulerExamination.Size = new System.Drawing.Size(242, 20);
            this.textBoxPeselSchedulerExamination.TabIndex = 16;
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
            this.exterminations_viewDataGridView.Size = new System.Drawing.Size(770, 608);
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
            // exterminations_viewBindingSource
            // 
            this.exterminations_viewBindingSource.DataMember = "Exterminations_view";
            this.exterminations_viewBindingSource.DataSource = this.dataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1198, 658);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Statystyki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            this.chart2.DataSource = this.countByMonthviewBindingSource;
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(594, 40);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Ilość przyjętych pacjentów w miesiącu przez wszystkich pracowników";
            series5.XValueMember = "visitMonth";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.YValueMembers = "visitCount";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(552, 534);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // countByMonthviewBindingSource
            // 
            this.countByMonthviewBindingSource.DataMember = "CountByMonth_view";
            this.countByMonthviewBindingSource.DataSource = this.dataSet;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.DataSource = this.countvisitsBindingSource;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(55, 40);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Ilość przyjętych pacjentów ogółem";
            series6.XValueMember = "doctor";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YValueMembers = "visitCount";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(506, 534);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // countvisitsBindingSource
            // 
            this.countvisitsBindingSource.DataMember = "count_visits";
            this.countvisitsBindingSource.DataSource = this.dataSet;
            // 
            // countVisitByMonthviewBindingSource
            // 
            this.countVisitByMonthviewBindingSource.DataMember = "CountVisitByMonth_view";
            this.countVisitByMonthviewBindingSource.DataSource = this.dataSet;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dataSet;
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
            // patients_viewTableAdapter
            // 
            this.patients_viewTableAdapter.ClearBeforeFill = true;
            // 
            // count_visitsTableAdapter
            // 
            this.count_visitsTableAdapter.ClearBeforeFill = true;
            // 
            // countVisitByMonth_viewTableAdapter
            // 
            this.countVisitByMonth_viewTableAdapter.ClearBeforeFill = true;
            // 
            // countByMonth_viewTableAdapter
            // 
            this.countByMonth_viewTableAdapter.ClearBeforeFill = true;
            // 
            // visitBasics_viewTableAdapter
            // 
            this.visitBasics_viewTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Enabled = false;
            this.textBoxPesel.Location = new System.Drawing.Point(129, 72);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxPesel.TabIndex = 48;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new System.Drawing.Point(6, 75);
            label38.Name = "label38";
            label38.Size = new System.Drawing.Size(88, 13);
            label38.TabIndex = 48;
            label38.Text = "PESEL pacjenta:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1205, 710);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LogoutButton);
            this.MaximumSize = new System.Drawing.Size(1221, 755);
            this.MinimumSize = new System.Drawing.Size(1091, 612);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabAdministration.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicEmployeesBindingSource)).EndInit();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabVistis.ResumeLayout(false);
            this.tabVistis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBasics_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBasics_viewBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewBindingSource)).EndInit();
            this.tabSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewBindingSource)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countByMonthviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countvisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVisitByMonthviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientPesel;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker dateTimePickerSchedulerVisitsHours;
        private System.Windows.Forms.Button buttonSearchPatient;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePickerSchedulerVisit;
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
        private System.Windows.Forms.DateTimePicker dateTimePickerHouersSchedulerExamination;
        private System.Windows.Forms.ComboBox comboBoxSchedulerService;
        private System.Windows.Forms.Button buttonSearchPeselSchedulerExamination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSchedulerExamination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastNameSchedulerExamination;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxFirstNameSchedulerExamination;
        private System.Windows.Forms.TextBox textBoxPeselSchedulerExamination;
        private System.Windows.Forms.DataGridView exterminations_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button buttonSaveSchedulerExaminaion;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.BindingSource patients_viewBindingSource;
        private DataSetTableAdapters.Patients_viewTableAdapter patients_viewTableAdapter;
        private System.Windows.Forms.DataGridView patients_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource countvisitsBindingSource;
        private DataSetTableAdapters.count_visitsTableAdapter count_visitsTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource countVisitByMonthviewBindingSource;
        private DataSetTableAdapters.CountVisitByMonth_viewTableAdapter countVisitByMonth_viewTableAdapter;
        private System.Windows.Forms.BindingSource countByMonthviewBindingSource;
        private DataSetTableAdapters.CountByMonth_viewTableAdapter countByMonth_viewTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxArchive;
        private System.Windows.Forms.ComboBox comboBoxSelectMedicines;
        private System.Windows.Forms.BindingSource visitBasics_viewBindingSource;
        private DataSetTableAdapters.VisitBasics_viewTableAdapter visitBasics_viewTableAdapter;
        private System.Windows.Forms.DataGridView visitBasics_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.TextBox textBoxPesel;
    }
}

