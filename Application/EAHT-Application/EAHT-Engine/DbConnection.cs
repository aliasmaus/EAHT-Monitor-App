using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAHT_Engine
{
    /// <summary>
    /// Class to handle connection and data retrieval methods for the application
    /// Guide can be found in week 5 lecture slides
    /// Much of the code below has been copied and modified from the slides and the originals are included for reference
    /// </summary>
    class DbConnection
    {
        /// <summary>
        /// Below attributes are taken from week 5 lecture slides; Original code:
        /// <code>
        /// privatestringconnectionStr;
        /// //the SqlConnection object used to store the connection to the database 
        /// System.Data.SqlClient.SqlConnection connectionToDB;
        /// // the DataAdapter object used to open a table of the database
        /// private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        /// </code>
        /// </summary>
        private string connectionString;
        private System.Data.SqlClient.SqlConnection dbConnection;
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
    }
}
