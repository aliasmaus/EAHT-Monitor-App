using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EAHT_Engine
{
    /// <summary>
    /// Static class for methods andn properties relating to executing simple queries in the database with SQL
    /// </summary>
    public static class SqlQueryExecutor
    {

        private static readonly string selectAllStatement = "SELECT * FROM ";
        private static readonly string whereClause = " WHERE ";
        private static readonly string endQuery = ";";
        private static readonly string connectionString = Properties.Settings.Default.DbConnection;

        /// <summary>
        /// Gets the values of the second (id: 1) column of the named table in the database
        /// </summary>
        /// <param name="tableName">Name of the table to get column values from</param>
        /// <returns>values from column 1 (0 based index) as array of strings</returns>
        public static string[] GetColumnValuesAsString(string tableName)
        {
            DataSet data = SelectAllFromTable(tableName);
            DataTableReader reader = data.CreateDataReader();
            List<string> values = new List<string>();
            while (reader.Read())
            {
                values.Add(reader.GetString(1));
            }
            return values.ToArray();
        }
        /// <summary>
        /// Gets the values of the specified column in the named table in the database
        /// </summary>
        /// <param name="tableName">Name of table to get column values from</param>
        /// <param name="columnNumber">the identity of the column to retrieve (0 based index)</param>
        /// <returns>values from column as array of strings</returns>
        public static string[] GetColumnValuesAsString(string tableName, int columnNumber)
        {
            DataSet data = SelectAllFromTable(tableName);
            DataTableReader reader = data.CreateDataReader();
            List<string> values = new List<string>();
            while (reader.Read())
            {
                values.Add(reader.GetString(columnNumber));
            }
            return values.ToArray();
        }
        /// <summary>
        /// Gets the values of the specified column in the named table in the database with a where condition
        /// </summary>
        /// <param name="tableName">Name of table to get column values from</param>
        /// <param name="columnNumber">the identity of the column to retrieve (0 based index)</param>
        /// <param name="whereCondition">filters rows by this condition</param>
        /// <returns></returns>
        public static string[] GetColumnValuesAsString(string tableName, int columnNumber, string whereCondition)
        {
            DataSet data = SelectAllFromTable(tableName,whereCondition);
            DataTableReader reader = data.CreateDataReader();
            List<string> values = new List<string>();
            while (reader.Read())
            {
                values.Add(reader.GetInt32(columnNumber).ToString());
            }
            return values.ToArray();
        }
        /// <summary>
        /// Selects all columns from the given table
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns>Table named in argument</returns>
        public static DataSet SelectAllFromTable(string tableName)
        {
            DbConnection connection = new DbConnection(connectionString);
            connection.OpenConnection();
            DataSet data = connection.GetDataSet(selectAllStatement + tableName + endQuery);
            connection.CloseConnection();
            return data;
        }
		/// <summary>
        /// Selects all columns from the given table with a where condition
        /// </summary>
        /// <param name="tableName">Name of table to retrieve</param>
        /// <param name="whereCondition">optional where condition</param>
        /// <returns>Whole table as dataset</returns>
        public static DataSet SelectAllFromTable(string tableName, string whereCondition)
        {
            DbConnection connection = new DbConnection(connectionString);
            connection.OpenConnection();
            DataSet data = connection.GetDataSet(selectAllStatement + tableName + whereClause + whereCondition + endQuery);
            connection.CloseConnection();
            return data;
        }
		/// <summary>
        /// Selects the named columns (as array of strings) from the named table (no where condition).
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
		public static DataSet SelectColumnsFromTable(string[] columns, string tableName)
        {
            string statement = "SELECT (";
			foreach( string column in columns)
            {
                statement += column + ", ";
            }
            statement.Remove(statement.Length-2);
            statement += ") FROM " + tableName + endQuery;
            DbConnection connection = new DbConnection(connectionString);
            connection.OpenConnection();
            DataSet data = connection.GetDataSet(statement);
            connection.CloseConnection();
            return data;
        }
		/// <summary>
        /// Selects named columns from a named table with a filter.
        /// </summary>
        /// <param name="columns">array of column names as strings</param>
        /// <param name="tableName">table name to retrieve from</param>
        /// <param name="whereCondition">filter to apply</param>
        /// <returns></returns>
        public static DataSet SelectColumnsFromTable(string[] columns, string tableName, string whereCondition)
        {
            string statement = "SELECT ";
            foreach (string column in columns)
            {
                statement += column;
                if (column != columns[columns.Length-1])
                {
                    statement += ", ";
                }
            }
            statement += " FROM " + tableName;
            statement += whereClause + whereCondition + endQuery;
            DbConnection connection = new DbConnection(connectionString);
            connection.OpenConnection();
            DataSet data = connection.GetDataSet(statement);
            connection.CloseConnection();
            return data;
        }
        /// <summary>
        /// Inserts a new row into the named table
        /// </summary>
        /// <param name="tableName">name of the table to insert into</param>
        /// <param name="dataRow">values to insert as strings</param>
        /// <param name="columnString">the columns in bracket separated by commas written as a </param>
        public static void InsertIntoTable(string tableName, string[] dataRow, string columnString)
        {
            DbConnection connection = new DbConnection(Properties.Settings.Default.DbConnection);
            System.Data.SqlClient.SqlConnection dbConnection = connection.OpenConnection();
            string statement = "INSERT INTO " + tableName + columnString + " VALUES (";
            foreach(string item in dataRow)
            {
                statement += item + ",";
            }
            statement= statement.Substring(0,statement.Length-1);
            statement += ")" + endQuery;
            System.Data.SqlClient.SqlCommand sqlCommand = connection.GetSqlCommand(statement);
            sqlCommand.Connection = dbConnection;
            sqlCommand.ExecuteNonQuery();
            connection.CloseConnection();
            sqlCommand.Dispose();
        }
        /// <summary>
        /// Updates the named column values in the filtered rows in the named table
        /// </summary>
        /// <param name="tableName">name of table to update</param>
        /// <param name="updates">update string eg "name = Fred, age = 26"</param>
        /// <param name="whereCondition">filter to apply eg "ID = 4"</param>
        public static void UpdateTable(string tableName, string updates, string whereCondition)
        {
            DbConnection connection = new DbConnection(Properties.Settings.Default.DbConnection);
            System.Data.SqlClient.SqlConnection sqlconnection = connection.OpenConnection();
            string statement = "UPDATE " + tableName + " SET " + updates + whereClause + whereCondition + endQuery;
            System.Data.SqlClient.SqlCommand sqlCommand = connection.GetSqlCommand(statement);
            sqlCommand.Connection = sqlconnection;
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            connection.CloseConnection();
        }
        public static void DeleteRowFromTable(string tableName, string Id)
        {
            DbConnection connection = new DbConnection(Properties.Settings.Default.DbConnection);
            System.Data.SqlClient.SqlConnection sqlconnection = connection.OpenConnection();
            string statement = "DELETE FROM " + tableName + " WHERE Id=" + Id + endQuery;
            System.Data.SqlClient.SqlCommand sqlCommand = connection.GetSqlCommand(statement);
            sqlCommand.Connection = sqlconnection;
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            connection.CloseConnection();
        }
        public static void DeleteRowsFromTable(string tableName, string whereCondition)
        {
            DbConnection connection = new DbConnection(Properties.Settings.Default.DbConnection);
            System.Data.SqlClient.SqlConnection sqlconnection = connection.OpenConnection();
            string statement = "DELETE FROM " + tableName + " WHERE " + whereCondition + endQuery;
            System.Data.SqlClient.SqlCommand sqlCommand = connection.GetSqlCommand(statement);
            sqlCommand.Connection = sqlconnection;
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            connection.CloseConnection();
        }
    }
}
