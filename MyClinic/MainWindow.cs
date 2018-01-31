using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static MyClinic.DataSet;

namespace MyClinic
{
    public partial class MainWindow : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable medicalServices;
        private DataTable clinicEmployees;
        private string connectionString;
        private LINQToSQLDataContext db;
        private static MainWindow mainWindow;

        public MainWindow()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(clinicEmployees = new DataTable("ClinicEmployees"), comboBoxSchedulerDoctor, "select * from ClinicEmployees", "FirstName", "LastName");
            Update_combobox(medicalServices = new DataTable("MedicalServices"), comboBoxSchedulerService, "select * from MedicalServices", "ServiceName", "ServiceDescription");
            Update_combobox(medicalServices, comboBoxServicesServiceName, "select * from MedicalServices", "ServiceName", "ServiceDescription");
            Update_combobox(clinicEmployees, comboBoxVisitDoctor, "select * from ClinicEmployees", "FirstName", "LastName");
            Update_combobox(clinicEmployees, comboBoxServicesDoctor, "select * from ClinicEmployees", "FirstName", "LastName");

            connectionString = ConfigurationManager.ConnectionStrings["MyClinic.Properties.Settings.ClinicConnectionString"].ToString();
            db = new LINQToSQLDataContext(connectionString);
            
            FillDataGridViewVistis();
            FillDataGridViewServices();
            mainWindow = this;
        }

        private void FillDataGridViewVistis()
        {
            var selected = from patient in db.Patients
                            join visit in db.Visits on patient.PatientID equals visit.PatientID
                            join specialist in db.MedicalSpecialists on visit.MedicalSpecialistID equals specialist.MedicalSpecialistID
                            join employee in db.ClinicEmployees on specialist.EmployeeID equals employee.EmployeeID
                            where employee.EmployeeID == Authenticator.Instance.LoggedEmployee.EmployeeID 
                                && visit.VisitDate.Date == DateTime.Today
                            select new { FirstName = patient.FirstName, LastName = patient.LastName, VisitDate = visit.VisitDate};

            dataGridViewVistis.DataSource = selected;
            dataGridViewVistis.Columns[0].HeaderText = "Imię";
            dataGridViewVistis.Columns[1].HeaderText = "Nazwisko";
            dataGridViewVistis.Columns[2].HeaderText = "Data wizyty";
        }

        private void FillDataGridViewServices()
        {
            var selected = from patient in db.Patients
                           join examination in db.MedicalExaminations on patient.PatientID equals examination.PatientID
                           join service in db.MedicalServices on examination.MedicalServiceID equals service.MedicalServiceID
                           where examination.ExaminationDate.Date == DateTime.Today
                           select new { FirstName = patient.FirstName, LastName = patient.LastName, Date = examination.ExaminationDate, ServiceName = service.ServiceName };

            dataGridViewServices.DataSource = selected;
            dataGridViewServices.Columns[0].HeaderText = "Imię";
            dataGridViewServices.Columns[1].HeaderText = "Nazwisko";
            dataGridViewServices.Columns[2].HeaderText = "Data";
            dataGridViewServices.Columns[3].HeaderText = "Nazwa";
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji?", "Wyloguj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
 
            }
            
        }

        private void buttonSaveSchedule_Click(object sender, EventArgs e)
        {
            string schedulerDoctor = ((ComboBoxItem)comboBoxSchedulerDoctor.SelectedItem).Hidden["EmployeeID"].ToString();
            string schedulerService = ((ComboBoxItem)comboBoxSchedulerService.SelectedItem).Hidden["MedicalServiceID"].ToString();
            string schedulerPesel = textBoxSchedulerPesel.Text;
            string schedulerFirstName = textBoxSchedulerFirstName.Text;
            string schedulerLastName = textBoxSchedulerLastName.Text;
            string schedulerDate = dateTimePickerSchedulerVisit.Text;

        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (openNextWindow("AddPatientForm"))
            {
                AddPatientForm window = new AddPatientForm();
                window.Show();
            }
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EditPatientForm"))
            {
                EditPatientForm window = new EditPatientForm();
                window.Show();
            }
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveVisit_Click(object sender, EventArgs e)
        {
            string visitCode = textBoxVisitCode.Text;
            string visitDescription = textBoxVisitDescription.Text;
        }

        private void buttonSaveExamination_Click(object sender, EventArgs e)
        {
            string servicesServiceName = ((ComboBoxItem)comboBoxServicesServiceName.SelectedItem).Hidden["MedicalServiceID"].ToString();
        }

        private void buttonEditService_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string administrationServiceName = textBoxAdministrationServiceName.Text;
            string administrationDescription = textBoxAdministrationServiceDescription.Text;
            string administrationDrice = textBoxAdministrationServicePrice.Text;
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            ClinicEmployeesRow currentSelectedValue = (ClinicEmployeesRow)((DataRowView)clinicEmployeesBindingSource.Current).Row;
            //currentSelectedValue;
        }

        private void buttonEditEployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EditEmployeeForm"))
            {
                ClinicEmployeesRow currentSelectedValue = (ClinicEmployeesRow)((DataRowView)clinicEmployeesBindingSource.Current).Row;

                EditEmployeeForm window = new EditEmployeeForm(currentSelectedValue);
                window.Show();
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EmployeeForm"))
            {
                EmployeeForm window = new EmployeeForm();
                window.Show();
            }
        }

        private void buttonSearchPatient_Click(object sender, EventArgs e)
        {
            DataTable patient = new DataTable();
            string shedulerPesel = textBoxSchedulerPesel.Text;
            
            SqlCommand command = new SqlCommand("select * from Patients where PESEL = @shedulerPesel", connection);
            adapter.SelectCommand = command;
            adapter.SelectCommand.Parameters.AddWithValue("@shedulerPesel", shedulerPesel);
            adapter.Fill(patient);
            adapter.Update(patient);

            textBoxSchedulerFirstName.Text = patient.Rows[0]["FirstName"].ToString();
            textBoxSchedulerLastName.Text = patient.Rows[0]["LastName"].ToString();

        }

        private void buttonServicePatientSearch_Click(object sender, EventArgs e)
        {
            DataTable patient = createPatientTable(textBoxServicesPesel.Text);
            textBoxServicesCity.Text = fillPatientInformation(textBoxServicesPesel.Text, patient);

            textBoxServicesFirstName.Text = patient.Rows[0]["FirstName"].ToString();
            textBoxServicesLastName.Text = patient.Rows[0]["LastName"].ToString();
            textBoxServicesStreet.Text = patient.Rows[0]["Street"].ToString();
            textBoxServicesStreetNo.Text = patient.Rows[0]["StreetNumer"].ToString();
            textBoxServicesPostalCode.Text = patient.Rows[0]["PostalCode"].ToString();
            textBoxServicesPhoneNo.Text = patient.Rows[0]["PhoneNumber"].ToString();
        }

        private void buttonVisitPatientSearch_Click(object sender, EventArgs e)
        {
            DataTable patient = createPatientTable(textBoxVisitPesel.Text);
            textBoxVisitCity.Text = fillPatientInformation(textBoxVisitPesel.Text, patient);

            textBoxVisitFirstName.Text = patient.Rows[0]["FirstName"].ToString();
            textBoxVisitLastName.Text = patient.Rows[0]["LastName"].ToString();
            textBoxVisitStreet.Text = patient.Rows[0]["Street"].ToString();
            textBoxVisitStreetNo.Text = patient.Rows[0]["StreetNumer"].ToString();
            textBoxVisitPostalCode.Text = patient.Rows[0]["PostalCode"].ToString();
            textBoxVisitPhoneNo.Text = patient.Rows[0]["PhoneNumber"].ToString();

            try
            {
                var patientVisits = db.Visits.Where(v => v.PatientID == Int32.Parse(patient.Rows[0]["PatientID"].ToString()));

                textBoxVisitArchiveDescription.Text = String.Join(Environment.NewLine, patientVisits.Select(v => v.VisitDescription));
                textBoxVisitArchivCode.Text = String.Join(", ", patientVisits.Select(v => v.DiseaseClassification));

                var selected = from m in db.Medicines
                               join pm in db.PrescribedMedicines on m.MedicineID equals pm.MedicineID
                               join v in db.Visits on pm.VisitID equals v.VisitID
                               where v.PatientID == Int32.Parse(patient.Rows[0]["PatientID"].ToString())
                               select m;

                textBoxArchivMedicines.Text = String.Join(Environment.NewLine, selected.Select(m => m.MedicineName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean openNextWindow(string windowName)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == windowName)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DataTable createPatientTable(string servicePesel)
        {
            DataTable patient = new DataTable();

            SqlCommand command = new SqlCommand("select * from Patients where PESEL = @servicePesel", connection);
            adapter.SelectCommand = command;
            adapter.SelectCommand.Parameters.AddWithValue("@servicePesel", servicePesel);
            adapter.Fill(patient);
            adapter.Update(patient);

            return patient;
        }
        private string fillPatientInformation(string servicePesel, DataTable patient)
        {
            try
            {
                var city = db.Cities;
                var answer = city.Single(x => x.CityID == Int32.Parse(patient.Rows[0]["CityID"].ToString()));
                return answer.CityName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        public void Update_combobox(DataTable transaction, ComboBox combo, String select, String field, String field2)
        {
            try
            {
                if (transaction.Rows.Count == 0)
                {
                    adapter.SelectCommand = new SqlCommand(select, connection);
                    adapter.Fill(transaction);
                }
                combo.Items.Clear();
                for (int i = 0; i < transaction.Rows.Count; ++i)
                {
                    ComboBoxItem item = new ComboBoxItem()
                    {
                        Text = transaction.Rows[i][field].ToString() + " " + transaction.Rows[i][field2].ToString(),
                        Hidden = transaction.Rows[i]
                    };
                    combo.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void RefreshData()
        {
            //mainWindow.clinicEmployeesBindingSource.DataSource = mainWindow.dataSet.ClinicEmployees.Rows;
            //mainWindow.clinicEmployeesBindingSource.ResetBindings(false);
            //mainWindow.clinicEmployeesDataGridView.Refresh();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.CountByMonth_view' table. You can move, or remove it, as needed.
            this.countByMonth_viewTableAdapter.Fill(this.dataSet.CountByMonth_view);
            // TODO: This line of code loads data into the 'dataSet.CountVisitByMonth_view' table. You can move, or remove it, as needed.
            this.countVisitByMonth_viewTableAdapter.Fill(this.dataSet.CountVisitByMonth_view);
            // TODO: This line of code loads data into the 'dataSet.count_visits' table. You can move, or remove it, as needed.
            this.count_visitsTableAdapter.Fill(this.dataSet.count_visits);
            // TODO: This line of code loads data into the 'dataSet.Patients_view' table. You can move, or remove it, as needed.
            this.patients_viewTableAdapter.Fill(this.dataSet.Patients_view);
            // TODO: This line of code loads data into the 'dataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dataSet.Patients);
            // TODO: This line of code loads data into the 'dataSet.Exterminations_view' table. You can move, or remove it, as needed.
            this.exterminations_viewTableAdapter.Fill(this.dataSet.Exterminations_view);
            // TODO: This line of code loads data into the 'dataSet.Visits_view' table. You can move, or remove it, as needed.
            this.visits_viewTableAdapter.Fill(this.dataSet.Visits_view);
            // TODO: This line of code loads data into the 'dataSet.MedicalServices' table. You can move, or remove it, as needed.
            this.medicalServicesTableAdapter.Fill(this.dataSet.MedicalServices);
            // TODO: This line of code loads data into the 'dataSet.ClinicEmployees' table. You can move, or remove it, as needed.
            this.clinicEmployeesTableAdapter.Fill(this.dataSet.ClinicEmployees);
            // TODO: This line of code loads data into the 'dataSet.Employee_view' table. You can move, or remove it, as needed.
            this.employee_viewTableAdapter.Fill(this.dataSet.Employee_view);

        }

        private void clinicEmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clinicEmployeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void textBoxPatientPesel_TextChanged(object sender, EventArgs e)
        {
            patients_viewBindingSource.Filter = string.Format("PESEL LIKE '%{0}%'", textBoxPatientPesel.Text);
        }
    }
}
