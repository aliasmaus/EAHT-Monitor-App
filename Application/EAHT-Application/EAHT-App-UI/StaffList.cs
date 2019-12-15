using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAHT_Engine;
using System.Windows.Forms;

namespace EAHT_App_UI
{
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
            string[] columns = new string[7] {"ID_Number","First_Name","Last_Name","Position","Contact_Number","Address","Add_Information"};
            UpdateStaffList(columns);
        }
        // Method to give access into the Database
         private void UpdateStaffList(string[] columns)
        {
            // Get  access to the Data Base
            DataSet dataSource = SqlQueryExecutor.SelectColumnsFromTable(columns, "Staff");
            // Call the table
            dataSource.Tables[0].TableName = "Staff";
            // Display into DataGridViewer
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSource;
            dataGridView1.DataMember = "Staff";
        }

        // Button used to return to the main page
        private void button3_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Button used to call the form to add a new staff member
        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new StaffContactAdd page and open it
            StaffContactAdd staffContactAdd = new StaffContactAdd();
            staffContactAdd.Show();
        }
    }
}
