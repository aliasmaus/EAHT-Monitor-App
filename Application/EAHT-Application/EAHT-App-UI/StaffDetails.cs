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
    public partial class StaffDetails : Form
    {
        public StaffDetails()
        {
            InitializeComponent();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {

        }
        //Text box to show the Contact details
        private void textBox2_TextChanged(object sender, EventArgs e)
        {



            //Console.WriteLine("First Name: {0}"), FirstName;
            //Console.WriteLine("Last Name: ");
            //Console.WriteLine("Position: ");
            //Console.WriteLine("Id Number: ");
            //Console.WriteLine("Contact Number: ");
           // Console.WriteLine("Address: ");
            //Console.WriteLine("Additional Information: ");
        }

        //Text Box where to read the activity of an individual user
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Alarms triggered: ");
        }
    }
}
