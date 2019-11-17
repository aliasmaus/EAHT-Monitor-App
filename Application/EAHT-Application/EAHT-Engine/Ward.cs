using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EAHT_Engine
{
    public class Ward
    {
        private string name;
        private Bay[] bays;
        public Ward(int ID)
        {
            //Load info from database
            DataSet wardInfo;
            DbConnection connection = new DbConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EAHT-Database.mdf;Integrated Security=True;Connect Timeout=30");
            connection.openConnection();
            wardInfo = connection.getDataSet("SELECT * from Ward_Settings;");
            connection.closeConnection();
            DataTableReader reader = wardInfo.CreateDataReader();
            for (int i = 0; i < ID; i++)
            {
                reader.Read();
            }
            //Load data from reader
            name = reader.GetString(1);
            int nBays = reader.GetInt32(2);
            int nBeds = Convert.ToInt32(reader["Beds_Per_Bay"]);
            int nMonitors = Convert.ToInt32(reader["Monitors_Per_Bed"]);

            //Load bays
            bays = new Bay[nBays];
            for(int bay = 0; bay<nBays; bay++)
            {
                bays[bay] = new Bay(bay + 1, nBeds, nMonitors);
            }

        }

        public Bay[] Bays { get => bays; }
        public string Name { get => name; }
    }
}
