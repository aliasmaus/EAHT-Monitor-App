using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EAHT_App_UI
{
    class LoginBackEnd
    {
        //decalre properties 
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //intialise  
        public LoginBackEnd(string user, string pass)
        {
            this.Username = user;
            this.Userpassword = pass;
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
        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass)
        {

            //check username empty 
            if (string.IsNullOrEmpty(user))
            {
                Usernamebox.Show("Enter the username!");
                return false;

            }
            //check username is valid type 
            else if (StringValidator(user) == true)
            {
                Usernamebox.Show("Enter only text here");
                ClearTexts(user, pass);
                return false;
            }
            //check username is correct 
            else
            {
                if (Username != user)
                {
                    Usernamebox.Show("Username is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        passwordbox.Show("Enter the passowrd!");
                        return false;
                    }
                    //check password is valid 
                    else if (IntegerValidator(pass) == true)
                    {
                        passwordbox.Show("Enter only integer here");
                        return false;
                    }
                    //check password is correct 
                    else if (Userpassword != pass)
                    {
                        passwordbox.Show("Password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    return true;
                }
            }
        }
    }
}