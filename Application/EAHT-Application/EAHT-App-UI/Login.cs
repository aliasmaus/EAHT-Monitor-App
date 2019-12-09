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
            static int attempt = 3;
            public Login()
            {
                InitializeComponent();
            }


            private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                string username = usernnamebox.Text;
                string password = passwordbox.Text;
    

        if ((this.usernnamebox.Text == "Admin") && (this.passwordbox.Text == "admin"))
                {
                    attempt = 0;
                MessageBox.Show("you are granted with access");
                }
                else
                {
                    MessageBox.Show("you are not granted with access");
                }

