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
            string[] columns = new string[7] {"Id_Number","First_Name","Last_Name","Position","Contact_Number","Address","Add_Information" };
            //dataGridView1.DataSource = SqlQueryExecutor.SelectColumnsFromTable(columns,"Staff");
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
