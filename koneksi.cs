﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace db
{
    internal class koneksi
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = null;

            try
            {
                string sConnstring = "server = localhost;database= db_gunpla;uid=root;password=;";
                conn = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return conn;
        }
    }
}
