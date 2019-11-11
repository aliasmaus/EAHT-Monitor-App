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
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public static string SetValueForText6 = "";
        public static string SetValueForText7 = "";

        public StaffContactAdd()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffList obj = new StaffList();
            obj.Name = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            SetValueForText1 = txtFirstName.Text;
            SetValueForText7 = txtLastName.Text;
            SetValueForText2 = txtPosition.Text;
            SetValueForText3 = txtIdNumber.Text;
            SetValueForText4 = txtContactNumber.Text;
            SetValueForText5 = txtAddress.Text;
            SetValueForText6 = txtAddInformation.Text;

            StaffDetails stdtils = new StaffDetails();
            stdtils.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

