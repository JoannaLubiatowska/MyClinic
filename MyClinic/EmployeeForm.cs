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
    public partial class EmployeeForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable city;
        private DataTable voivodeships;
        private DataTable userGroups;
        private SqlCommand command;

        public EmployeeForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(city = new DataTable("City"), comboBoxEmployeeCity, "select * from Cities", "CityName");
            Update_combobox(voivodeships = new DataTable("Voivodeships"), comboBoxEmployeeVoivodeship, "select * from Voivodeships", "VoivodeshipName");
            Update_combobox(userGroups = new DataTable("UserGroups"), comboBoxEmployeeGroup, "select * from UserGroups", "GroupName");
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            adapter.SelectCommand = new SqlCommand("SELECT * FROM ClinicEmployees where 1 = 2", connection);
            adapter.Fill(dataSet, "ClinicEmployees");

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
            string password = Authenticator.EncodePassword(textBoxEmployeePassword.Text);
            string confirmPassword = Authenticator.EncodePassword(textBoxEmployeePasswordConfirm.Text);
            string group = ((ComboBoxItem)comboBoxEmployeeGroup.SelectedItem).Hidden["UserGroupID"].ToString();
            string picturePath = textBoxEmployeePicture.Text;
     
            if(password != confirmPassword)
            {
                MessageBox.Show("Wprowadzonne hasła nie zgadzają się. Spróbuj ponownie.");
            }
            else
            {
                if (picturePath.Length > 0)
                {
                    command = new SqlCommand("INSERT INTO ClinicEmployees(FirstName, LastName, Street, StreetNumer, PostalCode, CityID, PhoneNumber, EmployeeDescription, UserLogin, UserPassword, UserGroupID, Picture)" +
                                             "SELECT @firstName, @lastName, @street, @streetNo, @postalCode, @city, @phoneNo, @employeeDescription, @userLogin, @userPassword, @userGroupID, BulkColumn FROM OPENROWSET (Bulk '@picture', Single_Blob) as IMAGE", connection);
                }
                else
                {
                    command = new SqlCommand("INSERT INTO ClinicEmployees(FirstName, LastName, Street, StreetNumer, PostalCode, CityID, PhoneNumber, EmployeeDescription, UserLogin, UserPassword, UserGroupID) " +
                                       "VALUES(@firstName, @lastName, @street, @streetNo, @postalCode, @city, @phoneNo, @employeeDescription, @userLogin, @userPassword, @userGroupID)", connection);

                }
                adapter.InsertCommand = command;
                adapter.InsertCommand.Parameters.AddWithValue("@firstName", firstName);
                adapter.InsertCommand.Parameters.AddWithValue("@lastName", lastName);
                adapter.InsertCommand.Parameters.AddWithValue("@street", street);
                adapter.InsertCommand.Parameters.AddWithValue("@streetNo", streetNo);
                adapter.InsertCommand.Parameters.AddWithValue("@postalCode", postalCode);
                adapter.InsertCommand.Parameters.AddWithValue("@city", city);
                adapter.InsertCommand.Parameters.AddWithValue("@phoneNo", phoneNo);
                adapter.InsertCommand.Parameters.AddWithValue("@picture", picturePath);
                adapter.InsertCommand.Parameters.AddWithValue("@employeeDescription", description);
                adapter.InsertCommand.Parameters.AddWithValue("@userLogin", login);
                adapter.InsertCommand.Parameters.AddWithValue("@userPassword", password);
                adapter.InsertCommand.Parameters.AddWithValue("@userGroupID", group);

                adapter.InsertCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "ClinicEmployees");
                adapter.Update(dataSet, "ClinicEmployees");

                MessageBox.Show("Zapisano pracownika.");
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
