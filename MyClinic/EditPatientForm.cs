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
    public partial class EditPatientForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable voivodeships;
        private DataTable city;
        private Patient editedPatient;
        public EditPatientForm(Patients_viewRow currentSelectedValue)
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=ASIA-HP;Initial Catalog=Clinic;Persist Security Info=True;User ID=sa;Password=praktyka");
            adapter = new SqlDataAdapter();
            Update_combobox(city = new DataTable("City"), comboBoxNewPatientCity, "select * from Cities", "CityName");
            Update_combobox(voivodeships = new DataTable("Voivodeships"), comboBoxNewPatientVoivodeship, "select * from Voivodeships", "VoivodeshipName");

            editedPatient = GetPatientInfo(currentSelectedValue);
            textBoxNewPatientFirstName.Text = editedPatient.FirstName;
            textBoxNewPatientLastName.Text = editedPatient.LastName;
            textBoxNewPatientStreet.Text = editedPatient.Street;
            textBoxNewPatientStreetNo.Text = editedPatient.StreetNumer;
            textBoxNewPatientPostalCode.Text = editedPatient.PostalCode;

            DataTable temp = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Voivodeships where VoivodeshipID = " +
                "(SELECT VoivodeshipID FROM Cities WHERE CityID = @cityID); ", connection);
            adapter.SelectCommand = command;
            adapter.SelectCommand.Parameters.AddWithValue("@cityID", editedPatient.CityID);
            adapter.Fill(temp);
            adapter.Update(temp);

            comboBoxNewPatientVoivodeship.Text = temp.Rows[0]["VoivodeshipName"].ToString();
            comboBoxNewPatientCity.SelectedItem = comboBoxNewPatientCity.Items.Cast<ComboBoxItem>().Where(x => x.Hidden["CityID"].ToString().Equals(editedPatient.CityID.ToString())).Single();
            textBoxNewPatientPhoneNo.Text = editedPatient.PhoneNumber.ToString();
            textBoxNewPatientPesel.Text = editedPatient.PESEL;
            checkBoxNewPatientNFZ.Checked = editedPatient.NFZ;
        }

        private Patient GetPatientInfo(Patients_viewRow currentSelectedValue)
        {
            return MainWindow.Instance.Db.Patients.Single(pat => pat.PESEL.Equals(currentSelectedValue.PESEL));
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

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command;
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
                string nfz = checkBoxNewPatientNFZ.Checked.ToString();

   
                command = new SqlCommand("UPDATE Patients SET FirstName=@firstName, LastName=@lastName, Street=@street, StreetNumer=@streetNo, " +
                            "PostalCode= @postalCode, CityID=@city, PhoneNumber=@phoneNo, PESEL=@pesel, NFZ=@nfz " +
                            "WHERE PatientID=@PatientID", connection);

                adapter.UpdateCommand = command;
                adapter.UpdateCommand.Parameters.AddWithValue("@PatientID", editedPatient.PatientID);
                adapter.UpdateCommand.Parameters.AddWithValue("@firstName", firstName);
                adapter.UpdateCommand.Parameters.AddWithValue("@lastName", lastName);
                adapter.UpdateCommand.Parameters.AddWithValue("@street", street);
                adapter.UpdateCommand.Parameters.AddWithValue("@streetNo", streetNo);
                adapter.UpdateCommand.Parameters.AddWithValue("@postalCode", postalCode);
                adapter.UpdateCommand.Parameters.AddWithValue("@city", city);
                adapter.UpdateCommand.Parameters.AddWithValue("@phoneNo", phoneNo);
                adapter.UpdateCommand.Parameters.AddWithValue("@pesel", pesel);
                adapter.UpdateCommand.Parameters.AddWithValue("@nfz", nfz);

                adapter.UpdateCommand = command;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Patients");
                adapter.Update(dataSet, "Patients");

                MessageBox.Show("Zapisano pacjenta.");
                
            }catch(Exception ex)
            {
                MessageBox.Show("Spróbuj ponownie.");
            }
        }
    }
}
