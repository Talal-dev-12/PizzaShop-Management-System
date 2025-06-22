using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace pizza.Database
{
    internal class Connection
    {
        private static string connectionString = "server=localhost;port=3307;user=root;password=1234;database=pizza_order_db;";

        private static MySqlConnection? connection;

        public static MySqlConnection GetConnection()
        {
            if (connection == null)
                connection = new MySqlConnection(connectionString);

            return connection;
        }
        public static void Open()
        {
            if (connection == null)
                connection = new MySqlConnection(connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }
        public static void Close()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
