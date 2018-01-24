using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic
{
    public partial class AddPatientForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable city;
        private DataTable voivodeships;
        private SqlCommand command;

        public AddPatientForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(city = new DataTable("City"), comboBoxNewPatientCity, "select * from Cities", "CityName");
            Update_combobox(voivodeships = new DataTable("Voivodeships"), comboBoxNewPatientVoivodeship, "select * from Voivodeships", "VoivodeshipName");
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = new SqlCommand("SELECT * FROM Patients where 1 = 2", connection);
                adapter.Fill(dataSet, "Patients");

                string firstName = textBoxNewPatientFirstName.Text;
                string lastName = textBoxNewPatientLastName.Text;
                string street = textBoxNewPatientStreet.Text;
                string streetNo = textBoxNewPatientStreetNo.Text;
                string postalCode = textBoxNewPatientPostalCode.Text;
                string voivodeship = ((ComboBoxItem)comboBoxNewPatientVoivodeship.SelectedItem).Hidden["VoivodeshipID"].ToString();
                string city = ((ComboBoxItem)comboBoxNewPatientCity.SelectedItem).Hidden["CityID"].ToString();
                string phoneNo = textBoxNewPatientPhoneNo.Text;
                string pesel = textBoxNewPatientPesel.Text;
                bool nfz = checkBoxNewPatientNFZ.Checked;
                string userGroupID = "2";

                command = new SqlCommand("INSERT INTO Patients(FirstName, LastName, Street, StreetNumer, PostalCode, CityID, PhoneNumber, PESEL, NFZ, UserGroupID) " +
                    "VALUES(@firstName, @lastName, @street, @streetNo, @postalCode, @city, @phoneNo, @pesel, @nfz, @userGroupID)", connection);

                adapter.InsertCommand = command;
                adapter.InsertCommand.Parameters.AddWithValue("@firstName", firstName);
                adapter.InsertCommand.Parameters.AddWithValue("@lastName", lastName);
                adapter.InsertCommand.Parameters.AddWithValue("@street", street);
                adapter.InsertCommand.Parameters.AddWithValue("@streetNo", streetNo);
                adapter.InsertCommand.Parameters.AddWithValue("@postalCode", postalCode);
                adapter.InsertCommand.Parameters.AddWithValue("@city", city);
                adapter.InsertCommand.Parameters.AddWithValue("@phoneNo", phoneNo);
                adapter.InsertCommand.Parameters.AddWithValue("@pesel", pesel);
                adapter.InsertCommand.Parameters.AddWithValue("@nfz", nfz);
                adapter.InsertCommand.Parameters.AddWithValue("@userGroupID", userGroupID);

                adapter.InsertCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Patients");
                adapter.Update(dataSet, "Patients");
              
                MessageBox.Show("Zapisano pacjenta.");
                textBoxNewPatientFirstName.Clear();
                textBoxNewPatientLastName.Clear();
                textBoxNewPatientStreet.Clear();
                textBoxNewPatientStreetNo.Clear();
                textBoxNewPatientStreetNo.Clear();
                textBoxNewPatientPostalCode.Clear();
                textBoxNewPatientPhoneNo.Clear();
                textBoxNewPatientPesel.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
