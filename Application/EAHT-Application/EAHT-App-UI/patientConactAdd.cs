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
    public partial class patientConactAdd : Form
    {
        public patientConactAdd()
        {
            InitializeComponent();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            // Button used to add patient
            PatientDetails obj = new PatientDetails();
            obj.FirstName = txtFirstName.Text;              //Variable needs to be made
            obj.LastName = txtLastName.Text;                //Variable needs to be made
            obj.Position = txtPosition.Text;                //Variable needs to be made
            obj.IdNumber = txtIdNumber.Text;                //Variable needs to be made
            obj.ContactNumber = txtContactNumber.Text;      //Variable needs to be made
            obj.Address = txtAddress.Text;                  //Variable needs to be made
            obj.AddInformation = txtAddInformation.Text;    //Variable needs to be made

            PatientDetails patientDetails = new PatientDetails();
            patientDetails.Show();
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            // Button used to return to the previous page
            MonitorPage monitorPage = new MonitorPage();
            monitorPage.Show();
        }

        private void mainPageButton_Click(object sender, EventArgs e)
        {
            // Button used to return to the main page
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
