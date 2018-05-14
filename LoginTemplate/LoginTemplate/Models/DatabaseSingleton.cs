/** DatabaseSingleton
 * 
 * Created by: Andrew Huynh
 * Last updated: May 13, 2018
 * 
 * This is just for demonstration purposes only.
 * Please use an actual database with some kind of authentication security
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginTemplate.Models
{
    public class DatabaseSingleton
    {
        //singleton property, that holds the username and password
        public Dictionary<string, string> Database = new Dictionary<string, string>();

        private static DatabaseSingleton _instance;

        private DatabaseSingleton()
        {
            Database.Add("warmachine68", "WARMACHINEROX");
        }

        public static DatabaseSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseSingleton();
                }
                return _instance;
            }
        }
    }
}
