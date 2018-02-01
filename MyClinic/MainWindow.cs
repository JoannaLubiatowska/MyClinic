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
using System.Data.Linq;

namespace MyClinic
{
    public partial class MainWindow : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable medicalServices;
        private DataTable clinicEmployees;
        private DataTable medicines;
        private DataTable specialists;
        private DataTable patient;
        private string connectionString;
        private LINQToSQLDataContext db;
        private static MainWindow mainWindow;
        private bool selectedVisit;

        public MainWindow()
        {
            InitializeComponent();
            
            connectionString = ConfigurationManager.ConnectionStrings["MyClinic.Properties.Settings.ClinicConnectionString"].ToString();
            db = new LINQToSQLDataContext(connectionString);

            clinicEmployees = new DataTable();
            specialists = new DataTable();
            medicines = new DataTable();
            medicalServices = new DataTable("MedicalServices");

            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(specialists, comboBoxSchedulerDoctor, "select * from specialists_view", "{0} - {1} {2}", "MedicalSpecializationName", "FirstName", "LastName");
            Update_combobox(medicalServices, comboBoxSchedulerService, "select * from MedicalServices", "{0} {1}", "ServiceName", "ServiceDescription");
            Update_combobox(medicalServices, comboBoxServicesServiceName, "select * from MedicalServices", "{0} {1}", "ServiceName", "ServiceDescription");
            Update_combobox(clinicEmployees, comboBoxVisitDoctor, "select * from specialists_view", "{0} - {1} {2}", "MedicalSpecializationName", "FirstName", "LastName");
            Update_combobox(clinicEmployees, comboBoxServicesDoctor, "select * from ClinicEmployees", "{0} {1}", "FirstName", "LastName");
            Update_combobox(medicines, comboBoxSelectMedicines, "select * from Medicines", "{0} {1}", "MedicineName", "Amount");
            
            FillAutoCompleteValues(textBoxSchedulerPesel, db.Patients.Select(patient => patient.PESEL).ToArray());
            FillAutoCompleteValues(textBoxVisitPesel, db.Patients.Select(patient => patient.PESEL).ToArray());
            FillAutoCompleteValues(textBoxSchedulerLastName, db.Patients.Select(patient => patient.LastName).Distinct().ToArray());
            patients_viewBindingSource.Filter = "Zapisany = 1";
            visitBasics_viewBindingSource.Filter = string.Format("EmployeeID = {0} and VisitDate >= '{1}' and VisitDate <= '{2}'", Authenticator.Instance.LoggedEmployee.EmployeeID, DateTime.Now.Date, DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            FillDataGridViewServices();
            mainWindow = this;
        }

        private void FillAutoCompleteValues(TextBox textBox, string[] values)
        {
            AutoCompleteStringCollection peselACSC = new AutoCompleteStringCollection();
            peselACSC.AddRange(values);
            textBox.AutoCompleteCustomSource = peselACSC;
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
            if (comboBoxSchedulerDoctor.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano specjalisty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (db.Patients.Where(pat => pat.PESEL.Equals(textBoxSchedulerPesel.Text)).Count().Equals(0))
            {
                MessageBox.Show("Nie znaleziono pacjenta o podanym numerze PESEL.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var doctor = db.MedicalSpecialists.Where(empl => empl.MedicalSpecialistID.Equals((int)((ComboBoxItem)comboBoxSchedulerDoctor.SelectedItem).Hidden["MedicalSpecialistID"])).Single();
            var patient = db.Patients.Where(pat => pat.PESEL.Equals(textBoxSchedulerPesel.Text)).Single();
            DateTime schedulerDate = dateTimePickerSchedulerVisit.Value.Date.Add(dateTimePickerSchedulerVisitsHours.Value.TimeOfDay);

            Visit visit = new Visit()
            {
                MedicalSpecialist = doctor,
                Patient = patient,
                VisitDate = schedulerDate                
            };
            db.Visits.InsertOnSubmit(visit);
            db.SubmitChanges();

            MessageBox.Show("Nowa wizyta została zanotowana.", "Zapisano wizytę", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                Patients_viewRow currentSelectedValue = (Patients_viewRow)((DataRowView)patients_viewBindingSource.Current).Row;

                SqlCommand command;
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = new SqlCommand("SELECT * FROM Patients where 1 = 2", connection);
                adapter.Fill(dataSet, "Patients");

                command = new SqlCommand("UPDATE Patients SET Active=@active WHERE PESEL=@pesel", connection);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.Parameters.AddWithValue("@pesel", currentSelectedValue.PESEL);
                adapter.UpdateCommand.Parameters.AddWithValue("@active", 0);

                adapter.UpdateCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Patients");
                adapter.Update(dataSet, "Patients");

                MessageBox.Show("Wypisano pacjenta.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie zaznaczono pacjenta.");
            }
            
        }

        private void buttonSaveVisit_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            DataSet dataSet = new DataSet();
            adapter.SelectCommand = new SqlCommand("SELECT * FROM Visits where 1 = 2", connection);
            adapter.Fill(dataSet, "Visits");

            if (selectedVisit)
            {
                command = new SqlCommand("UPDATE Visits SET DiseaseClassification=@diseaseClassification, VisitDescription=@visitDescription WHERE VisitID=@visitID", connection);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.Parameters.AddWithValue("@visitID", ((VisitBasics_viewRow)((DataRowView)visitBasics_viewBindingSource.Current).Row).VisitID);
                adapter.UpdateCommand.Parameters.AddWithValue("@diseaseClassification", textBoxVisitCode.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@visitDescription", textBoxVisitDescription.Text);

                adapter.UpdateCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Visits");
                adapter.Update(dataSet, "Visits");

                MessageBox.Show("Zapisano.");

            }else if (!selectedVisit)
            {
                command = new SqlCommand("INSERT INTO Visits(PatientID, MedicalSpecialistID, DiseaseClassification, VisitDescription, VisitDate) " +
                    "VALUES(@patientID, @medicalSpecialistID, @diseaseClassification, @visitDescription, getdate());", connection);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.Parameters.AddWithValue("patientID", patient.Rows[0]["PatientID"].ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("medicalSpecialistID", ((ComboBoxItem)comboBoxVisitDoctor.SelectedItem).Hidden["MedicalSpecialistID"].ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@diseaseClassification", textBoxVisitCode.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@visitDescription", textBoxVisitDescription.Text);

                adapter.UpdateCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Visits");
                adapter.Update(dataSet, "Visits");

                MessageBox.Show("Zapisano.");
            }
            else
            {
                MessageBox.Show("Wybierz wizytę lub dodaj nową.");
            }
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
            string schedulerPesel = textBoxSchedulerPesel.Text;
            string schedulerLastName = textBoxSchedulerLastName.Text;

            if (schedulerPesel.Length > 0)
            {
                SqlCommand command = new SqlCommand("select * from Patients where PESEL = @shedulerPesel", connection);
                adapter.SelectCommand = command;
                adapter.SelectCommand.Parameters.AddWithValue("@shedulerPesel", schedulerPesel);
                adapter.Fill(patient);
                adapter.Update(patient);

                if (patient.Rows.Count > 0)
                {
                    textBoxSchedulerFirstName.Text = patient.Rows[0]["FirstName"].ToString();
                    textBoxSchedulerLastName.Text = patient.Rows[0]["LastName"].ToString();
                } else
                {
                    MessageBox.Show("Nie znaleziono pacjenta o podanym numerze PESEL.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (schedulerLastName.Length > 0)
            {
                SqlCommand command = new SqlCommand("select * from Patients where LastName LIKE @lastName", connection);
                adapter.SelectCommand = command;
                adapter.SelectCommand.Parameters.AddWithValue("@lastName", '%' + schedulerLastName + '%');
                adapter.Fill(patient);
                adapter.Update(patient);

                switch (patient.Rows.Count)
                {
                    case 0:
                        MessageBox.Show("Nie znaleziono pacjenta o podanym nazwisku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case 1:
                        textBoxSchedulerPesel.Text = patient.Rows[0]["PESEL"].ToString();
                        textBoxSchedulerFirstName.Text = patient.Rows[0]["FirstName"].ToString();
                        textBoxSchedulerLastName.Text = patient.Rows[0]["LastName"].ToString();
                        break;

                    default:
                        MessageBox.Show("Znaleziono więcej niż jedną osobę o danym nazwisku. Konieczne będzie podanie numeru PESEL", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
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
            selectedVisit = false;
            patient = createPatientTable(textBoxVisitPesel.Text);
            textBoxVisitCity.Text = fillPatientInformation(textBoxVisitPesel.Text, patient);

            textBoxVisitFirstName.Text = patient.Rows[0]["FirstName"].ToString();
            textBoxVisitLastName.Text = patient.Rows[0]["LastName"].ToString();
            textBoxPesel.Text = patient.Rows[0]["Pesel"].ToString();
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
        
        public void Update_combobox(DataTable transaction, ComboBox combo, String select, String format, params String[] fieldNames)
        {
            try
            {
                List<ComboBoxItem> list = new List<ComboBoxItem>();

                if (transaction.Rows.Count == 0)
                {
                    adapter.SelectCommand = new SqlCommand(select, connection);
                    adapter.Fill(transaction);
                }

                combo.Items.Clear();

                string.Format(format, fieldNames);

                for (int i = 0; i < transaction.Rows.Count; ++i)
                {
                    string text = format;

                    for (int paramNo = 0; paramNo < fieldNames.Length; paramNo++)
                    {
                        text = text.Replace($"{'{'}{paramNo}{'}'}", transaction.Rows[i][fieldNames[paramNo]].ToString());
                    }

                    ComboBoxItem item = new ComboBoxItem()
                    {
                        Text = text,
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
            // TODO: This line of code loads data into the 'dataSet.VisitBasics_view' table. You can move, or remove it, as needed.
            this.visitBasics_viewTableAdapter.Fill(this.dataSet.VisitBasics_view);
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

        private void textBoxPatientPesel_TextChanged(object sender, EventArgs e)
        {
            patients_viewBindingSource.Filter = string.Format("PESEL LIKE '%{0}%'", textBoxPatientPesel.Text);
        }

        private void checkBoxArchive_CheckedChanged(object sender, EventArgs e)
        {
            patients_viewBindingSource.Filter = string.Format("Zapisany = {0}", checkBoxArchive.Checked ? 0 : 1);
        }

        private void visitBasics_viewDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.selectedVisit = true;
            var Selected = ((VisitBasics_viewRow)((DataRowView)visitBasics_viewBindingSource.Current).Row);
            if (Selected != null)
            {
                Patient selectedPatient = db.Patients.Single(pat => pat.PatientID.Equals(Selected.PatientID));
                textBoxVisitFirstName.Text = selectedPatient.FirstName ?? "";
                textBoxVisitLastName.Text = selectedPatient.LastName ?? "";
                textBoxPesel.Text = selectedPatient.PESEL ?? "";
                textBoxVisitStreet.Text = selectedPatient.Street ?? "";
                textBoxVisitStreetNo.Text = selectedPatient.StreetNumer ?? "";
                textBoxVisitPostalCode.Text = selectedPatient.PostalCode ?? "";
                textBoxVisitCity.Text = selectedPatient.City.CityName ?? "";
                textBoxVisitPhoneNo.Text = selectedPatient.PhoneNumber.ToString() ?? "";

                try
                {
                    var patientVisits = db.Visits.Where(v => v.PatientID == selectedPatient.PatientID);

                    textBoxVisitArchiveDescription.Text = String.Join(Environment.NewLine, patientVisits.Select(v => v.VisitDescription));
                    textBoxVisitArchivCode.Text = String.Join(", ", patientVisits.Select(v => v.DiseaseClassification));

                    var selected = from m in db.Medicines
                                   join pm in db.PrescribedMedicines on m.MedicineID equals pm.MedicineID
                                   join v in db.Visits on pm.VisitID equals v.VisitID
                                   where v.PatientID == selectedPatient.PatientID
                                   select m;

                    textBoxArchivMedicines.Text = String.Join(Environment.NewLine, selected.Select(m => m.MedicineName).ToArray());
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

        private void buttonAddMedicine_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            DataSet dataSet = new DataSet();
            adapter.SelectCommand = new SqlCommand("SELECT * FROM PrescribedMedicines where 1 = 2", connection);
            adapter.Fill(dataSet, "PrescribedMedicines");

            command = new SqlCommand("INSERT INTO PrescribedMedicines(MedicineID, VisitID, DrugDosage) " +
                                    "VALUES(@medicineID, @visitID, @drugDosage); ", connection);

            adapter.UpdateCommand = command;
            adapter.UpdateCommand.Parameters.AddWithValue("@visitID", ((VisitBasics_viewRow)((DataRowView)visitBasics_viewBindingSource.Current).Row).VisitID);
            adapter.UpdateCommand.Parameters.AddWithValue("@medicineID", ((ComboBoxItem)comboBoxSelectMedicines.SelectedItem).Hidden["MedicineID"].ToString());
            adapter.UpdateCommand.Parameters.AddWithValue("@drugDosage", "1x1");

            adapter.UpdateCommand = command;
            adapter.SelectCommand = command;
            adapter.Fill(dataSet, "PrescribedMedicines");
            adapter.Update(dataSet, "PrescribedMedicines");

            MessageBox.Show("Zapisano.");
        }
    }
}
