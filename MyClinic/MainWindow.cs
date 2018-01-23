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

namespace MyClinic
{
    public partial class MainWindow : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataRow element;
        private DataTable visits;
        private DataTable medicalExaminations;
        private DataTable patients;
        private DataTable medicalServices;
        private DataTable clinicEmployees;
        public MainWindow()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(clinicEmployees = new DataTable("ClinicEmployees"), comboBoxSchedulerDoctor, "select * from ClinicEmployees", "FirstName", "LastName");
            Update_combobox(medicalServices = new DataTable("MedicalServices"), comboBoxSchedulerService, "select * from MedicalServices", "ServiceName", "Price");
            Update_combobox(medicalServices, comboBoxServicesServiceName, "select * from MedicalServices", "ServiceName", "ServiceDescription");

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
            string schedulerAddress = textBoxSchedulerAddress.Text;
            string schedulerDate = dateTimePickerScheduler.Text;
            string schedulerHour = textBoxSchedulerHour.Text;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string patientPesel = textBoxPatientPesel.Text;


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

        private void buttonMedicines_Click(object sender, EventArgs e)
        {
            if (openNextWindow("MedicinesForm"))
            {
                MedicinesForm window = new MedicinesForm();
                window.Show();
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

        }

        private void buttonEditEployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EditEmployeeForm"))
            {
                EditEmployeeForm window = new EditEmployeeForm();
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
    }
}
