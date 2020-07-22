using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD157_Coursework
{
	static class Utils
	{
		public static List<String> GetTables()
		{
            List<String> tables = new List<String>();

            using(MySqlConnection connection = new MySqlConnection(Database.connectionString))
            {
                string query = "SHOW TABLES FROM " + Database.database;

                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        tables.Add(reader[0].ToString());
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }
            }

            return tables;
        }

        public static DataTable GetTableContent(String table)
        {
            using(MySqlConnection connection = new MySqlConnection(Database.connectionString))
            {
                string query = "SELECT * FROM " + Database.database + "." + table;

                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                    return null;
                }
            }
        }

        public static DataTable GetTableContentByID(String table, String filter)
        {
            using(MySqlConnection connection = new MySqlConnection(Database.connectionString))
            {
                string query = "SELECT * FROM " + Database.database + "." + table + " WHERE UserID=" + filter;

                switch(table)
                {
                    case "messages":
                        query = "SELECT * FROM " + Database.database + "." + table + " WHERE SenderID=" + filter + " OR ReceiverID=" + filter;
                        break;
                    case "friends":
                        query = "SELECT * FROM " + Database.database + "." + table + " WHERE UserID_1=" + filter;
                        break;
                }

                try
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                    return null;
                }
            }
        }
    }
}
