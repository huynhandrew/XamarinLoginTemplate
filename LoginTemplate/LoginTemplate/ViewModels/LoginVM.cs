/** LoginVM
 * Created by Andrew Huynh
 * Last Updated: May 13, 2018
 * This viewmodel handles the user input for username and password
 * It has one method, which is the login
 */
using System;
using System.Collections.Generic;
using System.Text;
using LoginTemplate.Models;

namespace LoginTemplate.ViewModels
{
    public class LoginVM
    {
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public bool Login()
        {
            string pass = "";
            bool loginChk = false;
            Dictionary<string, string> db = DatabaseSingleton.Instance.Database;
            
            try
            {
                if (db.TryGetValue(Username, out pass))
                {
                    if (Password == pass)
                    {
                        loginChk = true;
                    }
                }
            }
            catch
            {
                return loginChk;
            }
            return loginChk;
        }
    }
}
