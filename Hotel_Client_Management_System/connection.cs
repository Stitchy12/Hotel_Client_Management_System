using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Client_Management_System
{
    public static class DatabaseHelper
    {
        private static string connString = "server=localhost;database=tessapartelledatabase;uid=root;password=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
             
        }
    }
}
