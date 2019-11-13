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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            // Button used to return to previous page
            //MonitorPage monitorPage = new MonitorPage();
            //monitorPage.Show();
        }

        private void mainPageButton_Click(object sender, EventArgs e)
        {
            // Button used to return to the main page
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void deleteActivityButton_Click(object sender, EventArgs e)
        {
            // Button used to detail patient from database
            // WIP WIP WIP
        }

        private void patientNameList_TextChanged(object sender, EventArgs e)
        {
            // Code within the text box
            // Displays the patient names from database
            Console.WriteLine("PATIENT LIST");
            Console.WriteLine("{0}", patientNameList);  // The list will expand downwards
            //  LIST NEEDS TO BE MADE!
        }
    }
}
