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
    public partial class Patient_Details : Form
    {
        public Patient_Details()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ID:");
            Console.WriteLine("");
            Console.WriteLine("First Name:");
            Console.WriteLine("");
            Console.WriteLine("Last Name:");
            Console.WriteLine("");
            Console.WriteLine("Address:");
            Console.WriteLine("");
            Console.WriteLine("DOB:");
            Console.WriteLine("");
            Console.WriteLine("E-Mail:");
            Console.WriteLine("");
            Console.WriteLine("Phone Number:");
            Console.WriteLine("");
            Console.WriteLine("Bay Allocated:");
            Console.WriteLine("");
            Console.WriteLine("Bed Allocated:");
            Console.WriteLine("");
        }
    }
}
