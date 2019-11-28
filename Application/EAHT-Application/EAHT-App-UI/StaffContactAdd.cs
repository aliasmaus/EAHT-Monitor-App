using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAHT_Engine;


namespace EAHT_App_UI
{
    public partial class StaffContactAdd : Form
    {
        /// <summary>
        /// This is a page to add staff contact details
        /// <code></code>
        /// </summary>
        public StaffContactAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create objects from values type on textbox in Contact Register
            string[] obj = new string[7];
            obj[0] = txtFirstName.Text;
            obj[1] = txtLastName.Text;
            obj[2] = txtPosition.Text;
            obj[3] = txtIdNumber.Text;
            obj[4] = txtContactNumber.Text;
            obj[5] = txtAddress.Text;
            obj[6] = txtAddInformation.Text;
            obj[7] = txtPassword.Text;

            //listStaff.Items.Add(obj.ToString());
            SqlQueryExecutor.InsertIntoTable("Staff", obj, "(First_Name, Last_Name, Position, Id_Number, Contact_Number, Address, Add_Information, Password_Hash)");
            StaffDetails stdtils = new StaffDetails();
            stdtils.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StaffContactAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Button used to return to the main page
            //MainPage mainPage = new MainPage();
            //mainPage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Button used to return to the previous page
            //StaffList staafList = new StaffList();
            //staafList.Show();

        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

