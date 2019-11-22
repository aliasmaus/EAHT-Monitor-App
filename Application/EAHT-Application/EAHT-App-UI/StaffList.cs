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
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Show data recorded from Staff Members

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Button used to return to the main page
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
