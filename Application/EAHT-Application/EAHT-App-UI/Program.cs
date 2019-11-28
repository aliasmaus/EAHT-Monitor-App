using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAHT_Engine;

namespace EAHT_App_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

// FOR DEBUGGING WELCOME PAGE
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         //Application.Run(new WelcomePage(SqlQueryExecutor.GetColumnValuesAsString("Ward_Settings")));
            Application.Run(new Login());

            //Program opens with Login page
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());



        }
    }
}
