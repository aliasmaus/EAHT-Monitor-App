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
         private void UpdateStaffList(string[] columns)
        {

            // get table from database
            DataSet dataSource = SqlQueryExecutor.SelectColumnsFromTable(columns, "Staff");
            // name table
            dataSource.Tables[0].TableName = "Staff";
            // populate DataGridViewer
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSource;
            dataGridView1.DataMember = "Staff";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Button used to return to the main page
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button used to call the form to add a new staff member
            StaffContactAdd staffContactAdd = new StaffContactAdd();
            staffContactAdd.Show();
        }
    }
}
