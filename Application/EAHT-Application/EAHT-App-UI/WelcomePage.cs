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
    public partial class WelcomePage : Form
    {
        public WelcomePage(string[] wardNames)
        {
            InitializeComponent();
            WardSelectorBox.Items.AddRange(wardNames);
        }

        private void LoadWardMainPage(object sender, EventArgs e)
        {
            MainPage main = new MainPage(new Ward(WardSelectorBox.SelectedIndex));
            this.Close();
            main.Show();
        }
    }
}
