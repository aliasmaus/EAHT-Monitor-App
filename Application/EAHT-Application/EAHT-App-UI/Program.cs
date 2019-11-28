﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAHT_Engine;

namespace EAHT_App_UI
{
    static class Program
    {
        public static WelcomePage welcome;
        public static LoginPage login;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 

            // UNCOMMENT THIS CODE FOR DEBUGGING WELCOME PAGE

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WelcomePage(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings")));

            // UNCOMMENT THIS CODE FOR FINAL APPLICATION / DEBUGGING LOGIN PAGE

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login = new LoginPage();
            Application.Run(login);
        }
    }
}
