﻿using System;
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
        private string userName;

        public WelcomePage(string[] wardNames, string user)
        {
            InitializeComponent();
            WardSelectorBox.Items.AddRange(wardNames);
            this.userName = user;
        }

        private void LoadWardMainPage(object sender, EventArgs e)
        {
            MainPage main = new MainPage(new Ward(WardSelectorBox.SelectedIndex));
            this.Close();
            main.Show();
        }

        private void OpenWardConfig(object sender, EventArgs e)
        {
            WardConfigPage configPage = new WardConfigPage(userName);
            configPage.Show();
            this.Close();
        }

        private void ShowLoginDialogue(object sender, FormClosedEventArgs e)
        {
            //Program.login.Show();
        }
    }
}
