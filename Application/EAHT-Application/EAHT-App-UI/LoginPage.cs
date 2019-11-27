using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EAHT_Engine;

namespace EAHT_App_UI
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LoginPage : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            
            string hash = PasswordCryptography.ComputeSha256Hash("password");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            string connStr = Properties.Settings.Default.DBconnection;

            // It allows comunication between the Database's source and the application
            System.Data.SqlClient.SqlConnection dbConnection = new SqlConnection(connStr);  // @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\EAHT - Monitor - App\Application\EAHT - Application\EAHT - Engine\EAHT - Database.mdf; Integrated Security = True; Connect Timeout = 30");

            //SQL query. 
            SqlDataAdapter dataAdapter= new SqlDataAdapter("SELECT * FROM Staff WHERE First_Name = ' " + textBox1.Text + " 'AND Password_Hash = ' " + textBox2.Text + "'", dbConnection);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);

            //If the all rows of the Login's table are matching, the login is sucessful and directs to main menu
            if (data.Rows.Count == 1)
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
            {
                //Error message
                MessageBox.Show("Invalid Username or Password. Please insert your details again");
            }
            //It needs to be tested!!! It was working yesterday, before the merges.
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
