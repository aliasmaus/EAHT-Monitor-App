using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAHT_App_UI
{
    public partial class StaffContactAdd : Form
    {

        public StaffContactAdd()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create objects from values type on textbox in Contact Register
            StaffDetails obj = new StaffDetails();
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.Position = txtPosition.Text;
            obj.IdNumber = txtIdNumber.Text;
            obj.ContactNumber = txtContactNumber.Text;
            obj.Address = txtAddress.Text;
            obj.AddInformation = txtAddInformation.Text;

            StaffDetails stdtils = new StaffDetails();
            stdtils.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StaffContactAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

