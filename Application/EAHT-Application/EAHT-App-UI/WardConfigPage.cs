using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAHT_Engine;

namespace EAHT_App_UI
{
    public partial class WardConfigPage : Form
    {
        private string user;
        public WardConfigPage(string userName)
        {
            InitializeComponent();
            this.user = userName;
            // get ward names
            string[] wardNames = SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings");
            // update UI
            EditSelectWardDropdown.Items.AddRange(wardNames);
            DeleteWardSelectBox.Items.AddRange(wardNames);
            UpdateWardDataGrid();
        }
        private void UpdateWardDataGrid()
        {
            // get table from database
            DataSet dataSource = SqlQueryExecutor.SelectAllFromTable("Ward_Settings");
            // name table
            dataSource.Tables[0].TableName = "Ward_Settings";
            // populate DataGridViewer
            WardDataGridView.AutoGenerateColumns = true;
            WardDataGridView.DataSource = dataSource;
            WardDataGridView.DataMember = "Ward_Settings";
        }

        private void OpenWelcomePage(object sender, EventArgs e)
        {
            // open a new welcome 
            Program.welcome = new WelcomePage(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings"),user);
            Program.welcome.Show();
            this.Hide();
        }

        private void EditWardSelected(object sender, EventArgs e)
        {
            // show ward config edit controls
            ConfigureDefaultsBox.Visible = true;
            ConfigureDefaultsBox.Enabled = true;
            SelectBayBox.Visible = true;
            SelectBayBox.Enabled = true;
            // get ward data
            DataSet wardData = SqlQueryExecutor.SelectAllFromTable("Ward_Settings", "Id=" + EditSelectWardDropdown.SelectedIndex);
            DataTableReader reader = wardData.CreateDataReader();
            reader.Read();
            // update UI
            EditDefaultNumberOfBaysSelect.Value = reader.GetInt32(2);
            EditDefaultBedsPerBaySelect.Value = reader.GetInt32(3);
            EditDefaultMonitorsPerBedSelect.Value = reader.GetInt32(4);
            ResetBaysList(reader.GetInt32(2));
        }
        private void ResetBaysList(int nBays)
        {
            // get list of numbers in range 1-nBays as strings
            string[] menuItems = new string[nBays];
            for (int i = 0; i < nBays; i++)
            {
                menuItems[i] = (i + 1).ToString();
            }
            // add items to bays dropdown
            SelectBayDropdown.Items.AddRange(menuItems);
        }

        private void ShowBedsInBaysConfig(object sender, EventArgs e)
        {
            ConfigureDefaultsBox.Visible = false;
            ConfigureDefaultsBox.Enabled = false;
            ConfigureBedsInBaysBox.Visible = true;
            ConfigureBedsInBaysBox.Enabled = true;
            SelectBayBackButton.Visible = true;
            SelectBayBackButton.Enabled = true;
            
        }

        private void BackToConfigureWard(object sender, EventArgs e)
        {
            ConfigureDefaultsBox.Visible = true;
            ConfigureDefaultsBox.Enabled = true;
            ConfigureBedsInBaysBox.Visible = false;
            ConfigureBedsInBaysBox.Enabled = false;
            SelectBayBackButton.Visible = false;
            SelectBayBackButton.Enabled = false;

        }

        private void AddDefaultBaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddWardButton_Click(object sender, EventArgs e)
        {
            // If ward name is acceptable length then add ward to database, confirm to user and clear values from form
            if(AddWardNameText.Text.Length > 5)
            {
                // Insert values
                SqlQueryExecutor.InsertIntoTable("Ward_Settings", new string[4] { "\'" + AddWardNameText.Text + "\'", AddWardDefaultBedsNumber.Value.ToString(), AddWardDefaultBayNumber.Value.ToString(), AddWardDefaultMonitorsNumber.Value.ToString() }, "");
                // Reset dropdowns
                EditSelectWardDropdown.Items.Clear();
                DeleteWardSelectBox.Items.Clear();
                string[] newWards = SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings");
                EditSelectWardDropdown.Items.AddRange(newWards);
                DeleteWardSelectBox.Items.AddRange(newWards);
                // Show message
                MessageBox.Show("Success, ward added.");
                // Clear values
                AddWardNameText.Text = "";
                AddWardDefaultBayNumber.Value = 0;
                AddWardDefaultBedsNumber.Value = 0;
                AddWardDefaultMonitorsNumber.Value = 0;
                // Update viewer
                UpdateWardDataGrid();
            }
            // Otherwise show an error message
            else
            {
                MessageBox.Show("Ward name must be minimum 5 characters in length");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Confirm deletion
            DialogResult confirmation = MessageBox.Show("This will permenantly delete the ward and all associated settings\nAre you sure you want to perform this action?","Confirm delete",MessageBoxButtons.OKCancel);
            // If confirmed
            if(confirmation == DialogResult.OK)
            {
                // Delete row from table
                SqlQueryExecutor.DeleteRowsFromTable("Ward_Settings", "Ward_Name=" + "\'" + DeleteWardSelectBox.SelectedItem + "\'");
                // User feedback
                MessageBox.Show("Ward deleted");
                // Update UI
                EditSelectWardDropdown.Items.Clear();
                DeleteWardSelectBox.Items.Clear();
                string[] newWards = SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings");
                EditSelectWardDropdown.Items.AddRange(newWards);
                DeleteWardSelectBox.Items.AddRange(newWards);
                UpdateWardDataGrid();
            }
        }

        private void EditDefaultsUpdateButton_Click(object sender, EventArgs e)
        {
            // Edit rows in database
            SqlQueryExecutor.UpdateTable("Ward_Settings", "Beds_Per_Bay=" + EditDefaultBedsPerBaySelect.Value,"Id=" + EditSelectWardDropdown.SelectedIndex);
            SqlQueryExecutor.UpdateTable("Ward_Settings", "Number_Of_Bays=" + EditDefaultNumberOfBaysSelect.Value, "Id=" + EditSelectWardDropdown.SelectedIndex);
            SqlQueryExecutor.UpdateTable("Ward_Settings", "Monitors_Per_Bed=" + EditDefaultMonitorsPerBedSelect.Value, "Id=" + EditSelectWardDropdown.SelectedIndex);
            // Reset form
            SelectBayDropdown.Items.Clear();
            ResetBaysList(Convert.ToInt32(EditDefaultNumberOfBaysSelect.Value));
            UpdateWardDataGrid();
            // Feedback for user
            MessageBox.Show("Ward updated");
        }
    }
}
