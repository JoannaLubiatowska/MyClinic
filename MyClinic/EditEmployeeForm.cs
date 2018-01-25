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
using static MyClinic.DataSet;

namespace MyClinic
{
    public partial class EditEmployeeForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable voivodeships;
        private DataTable city;
        private DataTable userGroups;
        private DataTable medicalSpecialists;
        private DataTable medicalSpecializations;
        private ClinicEmployeesRow editedEmployee;

        public EditEmployeeForm(ClinicEmployeesRow currentSelectedValue)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(medicalSpecializations = new DataTable("MedicalSpecializations"), comboBoxEmployeeAddSpecialization, "select * from MedicalSpecializations", "MedicalSpecializationName");
            Update_combobox(city = new DataTable("City"), comboBoxEmployeeCity, "select * from Cities", "CityName");
            Update_combobox(voivodeships = new DataTable("Voivodeships"), comboBoxEmployeeVoivodeship, "select * from Voivodeships", "VoivodeshipName");
            Update_combobox(userGroups = new DataTable("UserGroups"), comboBoxEmployeeGroup, "select * from UserGroups", "GroupName");

            editedEmployee = currentSelectedValue;
            textBoxEmployeeFirstName.Text = currentSelectedValue.FirstName;

            textBoxEmployeeFirstName.Text = currentSelectedValue.FirstName;
            textBoxEmployeeLastName.Text = currentSelectedValue.LastName;
            textBoxEmployeeStreet.Text = currentSelectedValue.Street;
            textBoxEmployeeStreetNo.Text = currentSelectedValue.StreetNumer;
            textBoxEmployeePostalCode.Text = currentSelectedValue.PostalCode;

            DataTable temp = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Voivodeships where VoivodeshipID = " +
                "(SELECT VoivodeshipID FROM Cities WHERE CityID = @cityID); ", connection);
            adapter.SelectCommand = command;
            adapter.SelectCommand.Parameters.AddWithValue("@cityID", currentSelectedValue.CityID);
            adapter.Fill(temp);
            adapter.Update(temp);

            comboBoxEmployeeVoivodeship.Text = temp.Rows[0]["VoivodeshipName"].ToString();
            comboBoxEmployeeCity.SelectedItem = comboBoxEmployeeCity.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["CityID"].ToString().Equals(currentSelectedValue.CityID.ToString())).Single();
            textBoxEmployeePhoneNo.Text = currentSelectedValue.PhoneNumber.ToString();
            textBoxEmployeeDescription.Text = currentSelectedValue.EmployeeDescription;
            textBoxEmployeeLogin.Text = currentSelectedValue.UserLogin;
            comboBoxEmployeeGroup.SelectedItem = comboBoxEmployeeGroup.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["UserGroupID"].ToString().Equals(currentSelectedValue.UserGroupID.ToString())).Single();

            MemoryStream stream = new MemoryStream((byte[])currentSelectedValue.Picture);
            pictureBox.Image = Image.FromStream(stream); 
            fillSpecializationBoxes(currentSelectedValue.EmployeeID.ToString());
        }

        private void fillSpecializationBoxes(string employeeID)
        {
            DataTable temp = new DataTable();
            SqlCommand command = new SqlCommand("SELECT MedicalSpecializations.MedicalSpecializationName as name FROM MedicalSpecializations " +
                                "JOIN MedicalSpecialists ON MedicalSpecializations.MedicalSpecializationID = MedicalSpecialists.MedicalSpecializationID " +
                                "JOIN ClinicEmployees ON MedicalSpecialists.EmployeeID = ClinicEmployees.EmployeeID WHERE ClinicEmployees.EmployeeID = @employeeID", connection);

            adapter.SelectCommand = command;
            adapter.SelectCommand.Parameters.AddWithValue("@employeeID", employeeID);
            adapter.Fill(temp);
            adapter.Update(temp);

            textBoxEmployeeSpecialization.Text = String.Join(Environment.NewLine, temp.Select().Select(row => row["name"].ToString()).ToArray());
            //textBoxEmployeePicture.Text = currentSelectedValue.FirstName;
            //pictureBox.Text = currentSelectedValue.FirstName;
            //comboBoxEmployeeAddSpecialization.Text = currentSelectedValue.FirstName;
            //textBoxEmployeeNewSpecialization.Text = currentSelectedValue.FirstName;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = textBoxEmployeeFirstName.Text;
            string lastName = textBoxEmployeeLastName.Text;
            string street = textBoxEmployeeStreet.Text;
            string streetNo = textBoxEmployeeStreetNo.Text;
            string postalCode = textBoxEmployeePostalCode.Text;
            string voivodeship = ((ComboBoxItem)comboBoxEmployeeVoivodeship.SelectedItem).Hidden["VoivodeshipID"].ToString();
            string city = ((ComboBoxItem)comboBoxEmployeeCity.SelectedItem).Hidden["CityID"].ToString();
            string phoneNo = textBoxEmployeePhoneNo.Text;
            string description = textBoxEmployeeDescription.Text;
            string login = textBoxEmployeeLogin.Text;
            string password = textBoxEmployeePassword.Text;
            string confirmPassword = textBoxEmployeePasswordConfirm.Text;
            string group = ((ComboBoxItem)comboBoxEmployeeGroup.SelectedItem).Hidden["UserGroupID"].ToString();
            string specjalization = textBoxEmployeeSpecialization.Text;
            string picturePath = textBoxEmployeePicture.Text;
            string picture = pictureBox.Text;
            string addSpecjalization = ((ComboBoxItem)comboBoxEmployeeAddSpecialization.SelectedItem).Hidden["MedicalSpecializationID"].ToString();
            string newSpecjalization = textBoxEmployeeNewSpecialization.Text;
        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {

        }

        public static byte[] getPhoto(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    return reader.ReadBytes((int)stream.Length);
                }
            }
        }

        public void Update_combobox(DataTable transaction, ComboBox combo, String select, String field)
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
                        Text = transaction.Rows[i][field].ToString(),
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
