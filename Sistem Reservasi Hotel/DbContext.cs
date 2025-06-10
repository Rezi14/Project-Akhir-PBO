using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Sistem_Reservasi_Hotel.Models;

namespace Sistem_Reservasi_Hotel
{
    public class DbContext
    {
        private static string localhost = "localhost";
        private static string port = "5432";
        private static string username = "postgres";
        private static string password = "postgres";
        private static string database = "pbo akhir";

        public static NpgsqlConnection GetConnection()
        {
            string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
            return new NpgsqlConnection(connString);
        }
        //public static void CloseConnection()
        //{
        //    if (conn != null)
        //    {
        //        conn.Close();
        //        conn = null;
        //    }

        //}
    }

}
