﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Conference_Management_System
{
    internal class Database
    {
        static readonly string server = "127.0.0.1";
        static readonly string user = "root";
        static readonly string password = "";
        static readonly string database = "conference_data";

        public static string connection_string = "server='" + server + "'; user='" + user + "'; database='" +
        database + "'; password='" + password + "'";

        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);

        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        
    }

   
}
