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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            bool success = LoginBackEnd.LogUserIn(userName, password);

            if(success)
            {
                WelcomePage welcomePage = new WelcomePage(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings"));
                welcomePage.Show();
                this.Hide();
            }
            else
            {
                //Error message
                MessageBox.Show("Invalid Username or Password. Please insert your details again");
            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
    }
}
