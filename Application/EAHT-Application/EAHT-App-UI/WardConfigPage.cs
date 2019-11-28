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
            EditSelectWardDropdown.Items.AddRange(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings"));
        }

        private void OpenWelcomePage(object sender, EventArgs e)
        {
            Program.welcome = new WelcomePage(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings"),user);
            Program.welcome.Show();
            this.Hide();
        }

        private void EditWardSelected(object sender, EventArgs e)
        {
            ConfigureDefaultsBox.Visible = true;
            ConfigureDefaultsBox.Enabled = true;
            SelectBayBox.Visible = true;
            SelectBayBox.Enabled = true;
            DataSet wardData = SqlQueryExecutor.SelectAllFromTable("Ward_Settings", "Id=" + EditSelectWardDropdown.SelectedIndex);
            DataTableReader reader = wardData.CreateDataReader();
            reader.Read();
            EditDefaultNumberOfBaysSelect.Value = reader.GetInt32(3);
            EditDefaultBedsPerBaySelect.Value = reader.GetInt32(2);
            EditDefaultMonitorsPerBedSelect.Value = reader.GetInt32(4);
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
                EditSelectWardDropdown.Items.AddRange(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings"));
                // Show message
                MessageBox.Show("Success, ward added.");
                // Clear values
                AddWardNameText.Text = "";
                AddWardDefaultBayNumber.Value = 0;
                AddWardDefaultBedsNumber.Value = 0;
                AddWardDefaultMonitorsNumber.Value = 0;
            }
            // Otherwise show an error message
            else
            {
                MessageBox.Show("Ward name must be minimum 5 characters in length");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditDefaultsUpdateButton_Click(object sender, EventArgs e)
        {
            // Edit rows in database
            SqlQueryExecutor.UpdateTable("Ward_Settings", "Beds_Per_Bay=" + EditDefaultBedsPerBaySelect.Value,"Id=" + EditSelectWardDropdown.SelectedIndex);
            SqlQueryExecutor.UpdateTable("Ward_Settings", "Number_Of_Bays=" + EditDefaultNumberOfBaysSelect.Value, "Id=" + EditSelectWardDropdown.SelectedIndex);
            SqlQueryExecutor.UpdateTable("Ward_Settings", "Monitors_Per_Bed=" + EditDefaultMonitorsPerBedSelect.Value, "Id=" + EditSelectWardDropdown.SelectedIndex);
            // Feedback for user
            MessageBox.Show("Ward updated");
        }
    }
}
