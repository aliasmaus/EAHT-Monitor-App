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

namespace EAHT_App_UI
{
    public partial class LoginPage : Form
    {
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
            System.Data.SqlClient.SqlConnection dbConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\EAHT - Monitor - App\Application\EAHT - Application\EAHT - Engine\EAHT - Database.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter dataAdapter= new SqlDataAdapter("SELECT * FROM Login WHERE username = ' " + textBox1.Text + " 'AND password = ' " + textBox2.Text + "'", dbConnection);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);

            if (data.Rows.Count == 1)
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please insert your details again");
            }
            
        }
    }
}
