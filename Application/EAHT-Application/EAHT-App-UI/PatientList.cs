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
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Code used within the text box
            // Displays the patients
            Console.WriteLine("Patient Names: {0}", patientName);               // Variable still needs to be made
            Console.WriteLine("Patient Bed Number: {0}", patientBed);           // Variable still needs to be made
            Console.WriteLine("Patient Details: {0}", patientDetails);          // Variable still needs to be made
            Console.WriteLine("Patient Other Info: {0}", patientAdditional);    // Variable still needs to be made
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Button used to return to previous page
            MonitorPage monitorPage = new MonitorPage();
            monitorPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button used to return to the main page
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
