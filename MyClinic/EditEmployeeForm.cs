﻿using System;
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
        private DataTable medicalSpecializations;
        private ClinicEmployeesRow editedEmployee;

        public EditEmployeeForm(ClinicEmployeesRow currentSelectedValue)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(city = new DataTable("City"), comboBoxEmployeeCity, "select * from Cities", "CityName");
            Update_combobox(voivodeships = new DataTable("Voivodeships"), comboBoxEmployeeVoivodeship, "select * from Voivodeships", "VoivodeshipName");
            Update_combobox(userGroups = new DataTable("UserGroups"), comboBoxEmployeeGroup, "select * from UserGroups", "GroupName");
            Update_combobox(medicalSpecializations = new DataTable("MedicalSpecializations"), comboBoxEmployeeAddSpecialization, "select * from MedicalSpecializations", "MedicalSpecializationName");

            editedEmployee = currentSelectedValue;
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
            comboBoxEmployeeGroup.SelectedItem = comboBoxEmployeeGroup.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["UserGroupID"].ToString().Equals(currentSelectedValue.UserGroupID.ToString())).Single();
            textBoxEmployeePhoneNo.Text = currentSelectedValue.PhoneNumber.ToString();
            textBoxEmployeeDescription.Text = currentSelectedValue.EmployeeDescription;
            textBoxEmployeeLogin.Text = currentSelectedValue.UserLogin;

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
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            SqlCommand command;
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
            string picture = pictureBox.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Wprowadzonne hasła nie zgadzają się. Spróbuj ponownie.");
            }
            else
            {
                if (picturePath.Length > 0)
                {
                    command = new SqlCommand("UPDATE ClinicEmployees SET FirstName=@firstName, LastName=@lastName, Street=@street, StreetNumer=@streetNo, PostalCode= @postalCode, CityID=@city," +
                        "PhoneNumber=@phoneNo, EmployeeDescription=@employeeDescription, UserLogin=@userLogin, UserPassword=@userPassword, UserGroupID=@userGroupID, Picture=@picture " +
                        "WHERE EmployeeID=@employeeID", connection);
                    command.Parameters.AddWithValue("@picture", getPhoto(picturePath));
                }
                else
                {
                    command = new SqlCommand("UPDATE ClinicEmployees SET FirstName=@firstName, LastName=@lastName, Street=@street, StreetNumer=@streetNo, PostalCode= @postalCode, CityID=@city," +
                        "PhoneNumber=@phoneNo, EmployeeDescription=@employeeDescription, UserLogin=@userLogin, UserPassword=@userPassword, UserGroupID=@userGroupID " +
                        "WHERE EmployeeID=@employeeID", connection);
                }

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.Parameters.AddWithValue("@employeeID", editedEmployee.EmployeeID);
                adapter.UpdateCommand.Parameters.AddWithValue("@firstName", firstName);
                adapter.UpdateCommand.Parameters.AddWithValue("@lastName", lastName);
                adapter.UpdateCommand.Parameters.AddWithValue("@street", street);
                adapter.UpdateCommand.Parameters.AddWithValue("@streetNo", streetNo);
                adapter.UpdateCommand.Parameters.AddWithValue("@postalCode", postalCode);
                adapter.UpdateCommand.Parameters.AddWithValue("@city", city);
                adapter.UpdateCommand.Parameters.AddWithValue("@phoneNo", phoneNo);
                adapter.UpdateCommand.Parameters.AddWithValue("@employeeDescription", description);
                adapter.UpdateCommand.Parameters.AddWithValue("@userLogin", login);
                adapter.UpdateCommand.Parameters.AddWithValue("@userPassword", password);
                adapter.UpdateCommand.Parameters.AddWithValue("@userGroupID", group);

                adapter.UpdateCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "ClinicEmployees");
                adapter.Update(dataSet, "ClinicEmployees");

                MessageBox.Show("Zapisano pracownika.");
                MainWindow.RefreshData();
            }
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

        private void buttonAddSpecialization_Click(object sender, EventArgs e)
        {
            string specjalizationId = ((ComboBoxItem)comboBoxEmployeeAddSpecialization.SelectedItem).Hidden["MedicalSpecializationID"].ToString();
            DataSet dataSet = new DataSet();
            adapter.SelectCommand = new SqlCommand("SELECT * FROM MedicalSpecialists where 1 = 2", connection);
            adapter.Fill(dataSet, "MedicalSpecialists");

            SqlCommand command = new SqlCommand("INSERT INTO MedicalSpecialists(MedicalSpecializationID, EmployeeID) " +
                                       "VALUES(@specjalizationId, @employeeID)", connection);

            adapter.InsertCommand = command;
            adapter.InsertCommand.Parameters.AddWithValue("@specjalizationId", specjalizationId);
            adapter.InsertCommand.Parameters.AddWithValue("@employeeID", editedEmployee.EmployeeID);

            adapter.InsertCommand = command;
            adapter.SelectCommand = command;
            adapter.Fill(dataSet, "MedicalSpecialists");
            adapter.Update(dataSet, "MedicalSpecialists");

            MessageBox.Show("Dodano specjalność.");
        }
    }
}
