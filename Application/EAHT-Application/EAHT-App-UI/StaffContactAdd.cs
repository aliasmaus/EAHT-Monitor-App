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
        private const string ColumnString = "(First_Name, Last_Name, Position, , Contact_Number, Address, Add_Information, Password_Hash)";
        private const string V = "\'";

        public static string ColumnString1 => ColumnString;

        /// <summary
        /// This is the page to add or delete staff member details
        /// <code></code>
        /// </summary>
        public StaffContactAdd()
        {
            InitializeComponent();
            // get table from database
            DataSet dataSource = SqlQueryExecutor.SelectAllFromTable("Staff");
            DataTableReader reader = dataSource.CreateDataReader();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Create objects from values type on textbox in Contact Register
            string[] obj = new string[8];
            obj[0] = "\'" + txtFirstName.Text + "\'";
            obj[1] = "\'" + txtLastName.Text + "\'";
            obj[2] = "\'" + txtPosition.Text + "\'";
            obj[3] = "\'" + txtIdNumber.Text + "\'";
            obj[4] = "\'" + txtContactNumber.Text + "\'";
            obj[5] = "\'" + txtAddress.Text + "\'";
            obj[6] = "\'" + txtAddInformation.Text + "\'";
            obj[7] = "\'" + PasswordCryptography.ComputeSha256Hash(txtPassword.Text) + "\'";

            // Save all values to the Database
            SqlQueryExecutor.InsertIntoTable("Staff", obj, "(First_Name, Last_Name, Position, Id_Number, Contact_Number, Address, Add_Information, Password_Hash)");
            // Display a confirmation message
            MessageBox.Show("Staff added");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Button used to return to the main page
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Button used to return to the previous page
            StaffList staffList = new StaffList();
            staffList.Show();

        }

    }
}

