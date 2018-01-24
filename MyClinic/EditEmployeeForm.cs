using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyClinic.DataSet;

namespace MyClinic
{
    public partial class EditEmployeeForm : Form
    {
        private ClinicEmployeesRow editedEmployee;

        public EditEmployeeForm(ClinicEmployeesRow currentSelectedValue)
        {
            InitializeComponent();
            editedEmployee = currentSelectedValue;
            textBoxEmployeeFirstName.Text = currentSelectedValue.FirstName;

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
