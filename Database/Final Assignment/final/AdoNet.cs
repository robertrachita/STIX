using final.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    static class AdoNet
    {
        public static DateTime before;
        public static DateTime after;
        public static string conn = "Data Source = .\\SQLEXPRESS; Initial Catalog = Netflix; Integrated Security = True";


        // insert x amount of rows
        public static void AdoInsert(int rows)
        {
            try
            {
                Console.WriteLine("----------* Inserting " + rows + " rows of data");
                before = DateTime.Now;
                using (var connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string nonQuery = "INSERT INTO [Netflix].[dbo].[User] (user_email, user_password, date_of_birth, is_blocked, subscription_id) " +
                    "VALUES ('student@hotmail.com', 'abc', '11-09-2001', 0, 1)";
                    using (SqlCommand cmd = new SqlCommand(nonQuery, connection))
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            cmd.ExecuteNonQuery();
                        }
                        TimeSpan duration = after - before;
                        after = DateTime.Now;
                        Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Read x amount of rows
        public static void AdoRead(int rows)
        {
            string connOdbc = "Driver={SQL Server};SERVER=(local);Trusted_Connection=Yes;UID=admin;PWD=admin123;DATABASE=Netflix;";
            Console.WriteLine("----------* Reading " + rows + " rows of data");
            before = DateTime.Now;
            if (rows <= 0)
            {
                Console.WriteLine("No rows selected");
            }
            else
            {
                using (OdbcConnection odbcConnection = new OdbcConnection(connOdbc))
                {
                    odbcConnection.Open();
                    string query = "SELECT TOP " + rows + " * FROM [Netflix].[dbo].[User]";
                    OdbcCommand odbcCommand = odbcConnection.CreateCommand();
                    odbcCommand.Connection = odbcConnection;
                    before = DateTime.Now;
                    using (odbcCommand)
                    {
                        odbcCommand.CommandText = query;
                        odbcCommand.Connection = odbcConnection;
                        OdbcDataReader reader = odbcCommand.ExecuteReader();
                        reader.Close();
                    }

                    odbcConnection.Close();
                }
                after = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
            }

        }

        // update x amount of rows
        public static void AdoUpdate(int rows)
        {
            Console.WriteLine("----------* Updating" + rows + "rows of data");
            before = DateTime.Now;
            using (var connection = new SqlConnection(conn))
            {
                connection.Open();
                string updateQuery = "UPDATE TOP(" + rows + ") [Netflix].[dbo].[User] SET user_email = 'hot@hotmail.com'";
                SqlCommand cmd = connection.CreateCommand();
                cmd.Connection = connection;
                if (rows > 0)
                {
                    using (cmd)
                    {
                        cmd.CommandText = updateQuery;
                        cmd.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
        }

        // delete x amount of rows
        public static void AdoDelete(int rows)
        {
            Console.WriteLine("----------* Deleting " + rows + " rows of data");
            before = DateTime.Now;
            using (var connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                if (rows > 0)
                {
                    string deleteQuery = "DELETE TOP(" + rows + ") FROM [dbo].[User]";
                    using (sqlCommand)
                    {
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
        }
    }
}
