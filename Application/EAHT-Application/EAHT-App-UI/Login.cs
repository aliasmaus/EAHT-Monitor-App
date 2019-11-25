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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
            //Enter code here for your version of username and userpassword 
            LoginBackEnd login = new LoginBackEnd("admin", "1234");


            //exit button
            private void button1_Click(object sender, EventArgs e)
            {
                 this.Close();

             }

            private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                //enter your code for forget password case 
                MessageBox.Show("Under development");
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                //Enter your code for registration form of your choice 
                MessageBox.Show("Under development");
            }

            //login button
            private void button2_Click(object sender, EventArgs e)
            {
                //define local variables from the user inputs 
                string user = textBox1.Text;
                string pass = textBox2.Text;

                //check if eligible to be logged in 
                if (login.IsLoggedIn(user, pass))
                {
                    MessageBox.Show("You are logged in successfully");
                }
                else
                {
                    //show default login error message 
                    MessageBox.Show("Login Error!");
                }
            }
        }

  
}
