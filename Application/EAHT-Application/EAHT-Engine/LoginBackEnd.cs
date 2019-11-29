using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;

namespace EAHT_Engine
{
    // TODO: when a staff logs in the time needs to be recorded in the database
    // TODO: when a staff member logs in need to know if they are a manager, consultant or medical staff (or more than one of these) - see week 5 DB slides on users with multiple roles
    // TODO: when a staff member logs out the time needs to be recorded in the database
    public class LoginBackEnd
    {
        //decalre properties 
        private readonly string Username;
        public static string user;

        //intialise  
        public LoginBackEnd(string user)
        {
            this.Username = user;
            
        }
        //validate string 
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate integer 
        private bool IntegerValidator(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if a username password combination exists
        /// Still needs to record login times to database
        /// Need to make a session/login class to record session data
        /// </summary>
        /// <param name="userName">username to find in database</param>
        /// <param name="password">password to check</param>
        /// <returns>True for match found, false for no match found</returns>
        public static bool LogUserIn(string userName, string password)
        {
            // commented out so code is still present
            //string connStr = Properties.Settings.Default.DBconnection;

            //// It allows comunication between the Database's source and the application
            //System.Data.SqlClient.SqlConnection dbConnection = new SqlConnection(connStr);  // @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\EAHT - Monitor - App\Application\EAHT - Application\EAHT - Engine\EAHT - Database.mdf; Integrated Security = True; Connect Timeout = 30");

            ////SQL query. 
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Staff WHERE First_Name = ' " + userName + " 'AND Password_Hash = ' " + password + "'", dbConnection);
            //DataTable data = new DataTable();
            //dataAdapter.Fill(data);



            // Fixed and refactored to simplify

            // Checks input for conditions that would cause errors
            // not null and 1 character or more
            if (!(userName is null) && userName.Length > 1)
            {
                // Get password hash from database where first name matches
                DataSet dataset = SqlQueryExecutor.SelectColumnsFromTable(new string[1] { "Password_Hash" }, "Staff", "First_Name=\'" + userName + "\'");
                DataTableReader reader = dataset.CreateDataReader();

                // If there is a result
                if (reader.Read())
                {

                    // If the hashed password entered matches the stored hash
                    if (reader.GetString(0) == PasswordCryptography.ComputeSha256Hash(password))
                    {
                        // Password matches
                        user = userName;
                        return true;
                    }
                    // Password doesn't match
                    return false;
                }
                // Username not found or
            }
            // Input is invalid
            return false;
        }

        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if eligible to be logged in 
        //public internal bool IsLoggedIn(string user, string pass)
        // {
        /*
        //check user name empty 
        if (string.IsNullOrEmpty(user))
        {
            MessageBox.Show("Enter the user name!");
            return false;

        }
        //check user name is valid type 
        else if (StringValidator(user) == true)
        {
            MessageBox.Show("Enter only text here");
            ClearTexts(user, pass);
            return false;
        }
        //check user name is correct 
        else
        {
            if (Username != user)
            {
                MessageBox.Show("User name is incorrect!");
                ClearTexts(user, pass);
                return false;
            }
            //check password is empty 
            else
            {
                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Enter the passowrd!");
                    return false;
                }
                //check password is valid 
                else if (IntegerValidator(pass) == true)
                {
                    MessageBox.Show("Enter only integer here");
                    return false;
                }
                //check password is correct 
                else if (Userpassword != pass)
                {
                    MessageBox.Show("Password is incorrect");
                    return false;
                }
                else
                {
                    return true;
                }*/
        //return true;
    }
}
 
    


