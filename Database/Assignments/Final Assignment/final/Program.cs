using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
/*using System.Data.OleDb;
using System.Data.OracleClient;*/
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using final.Model;
using System.IO;

namespace final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET\n-----------------* Inserting 1 row of data");
            string conn = "Data Source = .\\SQLEXPRESS; Initial Catalog = Netflix; Integrated Security = True";
            try
            {
                /*                using (var connection = new SqlConnection(conn))
                                {*/
                //connection.Open();
                /*string nonQuery1 = "INSERT INTO [Netflix].[dbo].[User] (user_email, user_password, date_of_birth, is_blocked, subscription_id) " +
        "VALUES ('student@hotmail.com', 'abc', '11-09-2001', 0, 1)";
                using (SqlCommand cmd = new SqlCommand(nonQuery1, connection))
                {
                    DateTime before1 = DateTime.Now;
                    cmd.ExecuteNonQuery();
                    DateTime after1 = DateTime.Now;
                    double miliSeconds = (after1 - before1).TotalMilliseconds;
                    Console.WriteLine("Duration in miliseconds: {0}", miliSeconds);
                }

                Console.WriteLine("-----------------* Inserting 1,000 rows of data");
                SqlCommand command = connection.CreateCommand();
                using (command)
                {
                    DateTime before1 = DateTime.Now;
                    for (int i = 0; i < 1000; i++)
                    {
                        string nonQuery = "INSERT INTO [Netflix].[dbo].[User] (user_email, user_password, date_of_birth, is_blocked, subscription_id) " +
                            "VALUES ('student@hotmail.com', 'abc', '11-09-2001', 0, 1)";
                        command.CommandText = nonQuery;
                        command.ExecuteNonQuery();
                    }
                    DateTime after1 = DateTime.Now;
                    TimeSpan duration = after1 - before1;
                    Console.WriteLine("Duration in miliseconds: " + duration.TotalMilliseconds);
                }

                Console.WriteLine("-------* Inserting 100,000 rows of data");
                using (command)
                {
                    DateTime before1 = DateTime.Now;
                    for (int i = 0; i < 100000; i++)
                    {
                        string nonQuery = "INSERT INTO [Netflix].[dbo].[User] (user_email, user_password, date_of_birth, is_blocked, subscription_id) " +
                            "VALUES ('student@hotmail.com', 'abc', '11-09-2001', 0, 1)";
                        command.CommandText = nonQuery;
                        command.ExecuteNonQuery();
                    }
                    DateTime after1 = DateTime.Now;
                    TimeSpan duration = after1 - before1;
                    Console.WriteLine("Duration in miliseconds: " + duration.TotalMilliseconds);
                }

                Console.WriteLine("------------------* Inserting 1,000,000 rows of data");
                using (command)
                {
                    DateTime before1 = DateTime.Now;
                    for (int i = 0; i < 1000000; i++)
                    {
                        string nonQuery = "INSERT INTO [Netflix].[dbo].[User] (user_email, user_password, date_of_birth, is_blocked, subscription_id) " +
                            "VALUES ('student@hotmail.com', 'abc', '11-09-2001', 0, 1)";
                        command.CommandText = nonQuery;
                        command.ExecuteNonQuery();
                    }
                    DateTime after1 = DateTime.Now;
                    TimeSpan duration = after1 - before1;
                    Console.WriteLine("Duration in miliseconds: " + duration.TotalMilliseconds);
                }
            }

            string connOdbc = "Driver={SQL Server};SERVER=(local);Trusted_Connection=Yes;UID=admin;PWD=admin123;DATABASE=Netflix;";
            Console.WriteLine("----------------* Reading 1 row of data");

            DateTime before2 = DateTime.Now;
            using (OdbcConnection odbcConnection = new OdbcConnection(connOdbc))
            {
                string queryString = "SELECT TOP 1 * FROM [Netflix].[dbo].[User]";
                odbcConnection.Open();
                OdbcCommand odbcCommand = odbcConnection.CreateCommand();
                odbcCommand.Connection = odbcConnection;
                using (odbcCommand)
                {
                    odbcCommand.CommandText = queryString;
                    OdbcDataReader reader = odbcCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}: {1}", reader[0], reader[1]);
                    }
                    reader.Close();
                }

                DateTime after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
                Console.WriteLine("-------* Reading 1,000 rows of data");
                string query = "SELECT TOP 1000 * FROM [Netflix].[dbo].[User]";
                before2 = DateTime.Now;
                using (odbcCommand)
                {
                    odbcCommand.CommandText = query;
                    odbcCommand.Connection = odbcConnection;
                    OdbcDataReader reader = odbcCommand.ExecuteReader();
                    reader.Close();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);

                Console.WriteLine("--------------* Reading 100,000 rows of data");
                query = "SELECT TOP 100000 * FROM [Netflix].[dbo].[User]";
                before2 = DateTime.Now;
                using (odbcCommand)
                {
                    odbcCommand.CommandText = query;
                    odbcCommand.Connection = odbcConnection;
                    OdbcDataReader reader = odbcCommand.ExecuteReader();
                    reader.Close();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
                Console.WriteLine("---------------* Reading 1,000,000 rows of data");
                query = "SELECT TOP 1000000 * FROM [Netflix].[dbo].[User]";
                before2 = DateTime.Now;
                using (odbcCommand)
                {
                    odbcCommand.CommandText = query;
                    odbcCommand.Connection = odbcConnection;
                    OdbcDataReader reader = odbcCommand.ExecuteReader();
                    reader.Close();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
            }

            Console.WriteLine("-------------------* Updating 1 row of data");
            using (SqlConnection sqlConnection1 = new SqlConnection(conn))
            {
                sqlConnection1.Open();
                string updateQuery = "UPDATE TOP(1) [Netflix].[dbo].[User] SET user_email = 'hot@hotmail.com'";
                SqlCommand cmd = sqlConnection1.CreateCommand();
                cmd.Connection = sqlConnection1;
                before2 = DateTime.Now;
                using (cmd)
                {
                    cmd.CommandText = updateQuery;
                    cmd.ExecuteNonQuery();
                }
                DateTime after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);

                Console.WriteLine("------------------* Updating 1,000 rows of data");
                updateQuery = "UPDATE TOP(1000) [Netflix].[dbo].[User] SET user_email = 'hot#hotmail.com'";
                before2 = DateTime.Now;
                using (cmd)
                {
                    cmd.CommandText = updateQuery;
                    cmd.ExecuteNonQuery();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);

                Console.WriteLine("------------------* Updating 100,000 rows of data");
                updateQuery = "UPDATE TOP(100000) [Netflix].[dbo].[User] SET user_email = 'hot#hotmail.com'";
                before2 = DateTime.Now;
                using (cmd)
                {
                    cmd.CommandText = updateQuery;
                    cmd.ExecuteNonQuery();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);

                Console.WriteLine("------------------* Updating 1,000,000 rows of data");
                updateQuery = "UPDATE TOP(1000000) [Netflix].[dbo].[User] SET user_email = 'hot#hotmail.com'";
                before2 = DateTime.Now;
                using (cmd)
                {
                    cmd.CommandText = updateQuery;
                    cmd.ExecuteNonQuery();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
            }

            Console.WriteLine("--------------------* Deleting 1 row of data");
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                string deleteQuery = "DELETE TOP(1) FROM [dbo].[User]";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                before2 = DateTime.Now;
                using (sqlCommand)
                {
                    sqlCommand.CommandText = deleteQuery;
                    sqlCommand.ExecuteNonQuery();
                }
                DateTime after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
                Console.WriteLine("---------------* Deleting 1,000 rows of data");
                deleteQuery = "DELETE TOP(1000) FROM [dbo].[User]";
                before2 = DateTime.Now;
                using (sqlCommand)
                {
                    sqlCommand.CommandText = deleteQuery;
                    sqlCommand.ExecuteNonQuery();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
                Console.WriteLine("---------------* Deleting 100,000 rows of data");
                deleteQuery = "DELETE TOP(100000) FROM [dbo].[User]";
                before2 = DateTime.Now;
                using (sqlCommand)
                {
                    sqlCommand.CommandText = deleteQuery;
                    sqlCommand.ExecuteNonQuery();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
                Console.WriteLine("---------------* Deleting 1,000,000 rows of data");
                deleteQuery = "DELETE TOP(1000000) FROM [dbo].[User]";
                before2 = DateTime.Now;
                using (sqlCommand)
                {
                    sqlCommand.CommandText = deleteQuery;
                    sqlCommand.ExecuteNonQuery();
                }
                after2 = DateTime.Now;
                Console.WriteLine("Duration in miliseconds: {0}", (after2 - before2).TotalMilliseconds);
            }*/
                //==================== EF SECTION
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
                EntityFramework.EfInsert(100);

             //==================== END OF EF SECTION    
            Console.WriteLine("\nMongoDB\n------------* Inserting 1 row of data");
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = mongoClient.GetDatabase("Netflix");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("User");

            var doc = new BsonDocument
            {
                { "user_email", "student@hotmail.com" },
                { "user_password", "pass" },
                { "login_attempts", 0 },
                { "is_blocked", false },
                { "activation_date", DateTime.Now },
                { "subscription", 7.99 },
                { "included_quality", "SD" }
            };

            var before = DateTime.Now;
            collection.InsertOneAsync(doc);
            var after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}\n-------* Inserting 1,000 rows of data", (after - before).TotalMilliseconds);
            List<UserMongo> test = new List<UserMongo>();
            List<BsonDocument> test2 = new List<BsonDocument>();
            var collection2 = db.GetCollection<UserMongo>("User");
            for (int i = 0; i < 1000; i++)
            {
                UserMongo user = new UserMongo();
                user.user_email = "student@hotmail.com";
                user.user_password = "pass" + i;
                test.Add(user);
            }
            before = DateTime.Now;
            collection2.InsertManyAsync(test);
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}\n-------* Inserting 100,000 rows of data", (after - before).TotalMilliseconds);
            test2.Clear();
            for (int i = 0; i < 100000; i++)
            {
                var document = new BsonDocument
                {
                    { "user_email", "student@hotmail.com" },
                    { "user_password", "abcd123" + 1000 + i },
                    { "login_attempts", 0 },
                    { "is_blocked", 0 },
                    { "activation_date", DateTime.Now },
                    { "subscription_id", 1 }
                };
                test2.Add(document);
            }
            before = DateTime.Now;
            collection.InsertManyAsync(test2);
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}\n-------* Inserting 1,000,000 rows of data", (after - before).TotalMilliseconds);
            test2.Clear();
            for (int i = 0; i < 1000000; i++)
            {
                var document = new BsonDocument
                            {
                                { "user_email", "student@hotmail.com" },
                                { "user_password", "abcd123" + 100000 + i },
                                { "login_attempts", 0 },
                                { "is_blocked", 0 },
                                { "activation_date", DateTime.Now },
                                { "subscription_id", 1 }
                            };
                test2.Add(document);
            }
            before = DateTime.Now;
            collection.InsertManyAsync(test2);
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);

            Console.WriteLine("----------* Reading 1 row of data");
            before = DateTime.Now;
            var results = collection2.Find(_ => true).Limit(1).ToList();
            foreach (var result in results)
            {
                Console.WriteLine(result.user_email);
            }

            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);

            Console.Write("--------------* Reading 1,000 rows of data\n");
            before = DateTime.Now;
            results = collection2.Find(_ => true).Limit(1000).ToList();
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.Write("--------------* Reading 100,000 rows of data\n");
            before = DateTime.Now;
            results = collection2.Find(x => true).Limit(100000).ToList();
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.WriteLine("---------* Reading 1,000,000 rows of data");
            before = DateTime.Now;
            results = collection2.Find(x => true).Limit(1000000).ToList();
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);

            Console.WriteLine("---------* Updating 1 row of data");
            var search = Builders<UserMongo>.Filter.Regex("user_email", new BsonRegularExpression((new Regex("student@hotmail.com", RegexOptions.IgnoreCase))));
            var update = Builders<UserMongo>.Update.Set("user_email", "user@hotmail.com").Set(p => p.user_password, "aaaa");
            before = DateTime.Now;
            collection2.UpdateOne(search, update);
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.WriteLine("------* Updating 1,000 rows of data");
            before = DateTime.Now;
            collection2.Find(_ => true).Limit(1000).ForEachAsync(docs =>
            {
                collection2.UpdateOneAsync(Builders<UserMongo>.Filter.Regex("user_email", new BsonRegularExpression((new Regex("student@hotmail.com", RegexOptions.IgnoreCase)))), Builders<UserMongo>.Update.Set("user_email", "hotUser@hotmail.com"));
            });
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.WriteLine("------* Updating 100,000 rows of data");
            before = DateTime.Now;
            collection2.Find(_ => true).Limit(100000).ForEachAsync(docs =>
            {
                collection2.UpdateOneAsync(Builders<UserMongo>.Filter.Regex("user_email", new BsonRegularExpression((new Regex("student@hotmail.com", RegexOptions.IgnoreCase)))), Builders<UserMongo>.Update.Set("user_email", "hotUser@hotmail.com"));
            });
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.WriteLine("-------* Updating 1,000,000 rows of data");
            before = DateTime.Now;
            collection2.Find(_ => true).Limit(1000000).ForEachAsync(docs =>
            {
                collection2.UpdateOneAsync(Builders<UserMongo>.Filter.Regex("user_email", new BsonRegularExpression((new Regex("student@hotmail.com", RegexOptions.IgnoreCase)))), Builders<UserMongo>.Update.Set("user_email", "hotUser@hotmail.com"));
            });
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);

            Console.WriteLine("--------* Deleting 1 row of data");
            var emptyFilter = Builders<UserMongo>.Filter.Empty;
            before = DateTime.Now;
            collection2.DeleteOneAsync(emptyFilter);
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);

            Console.WriteLine("-------* Deleting 1,000 rows of data");
            before = DateTime.Now;
            collection2.Find(_ => true).Limit(1000).ForEachAsync(
                    docs =>
                    {
                        collection2.DeleteOne(Builders<UserMongo>.Filter.Empty);
                    }
                );
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.WriteLine("--------* Deleting 100,000 rows of data");
            collection2.Find(_ => true).Limit(100000).ForEachAsync(
                docs =>
                {
                    collection2.DeleteOne(Builders<UserMongo>.Filter.Eq(user => user.user_email, "student@hotmail.com"));
                }
            );
            after = DateTime.Now;

            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.WriteLine("--------* Deleting 1,000,000 rows of data");
            before = DateTime.Now;
            collection2.Find(_ => true).Limit(1000000).ForEachAsync(
                docs =>
                {
                    collection2.DeleteOne(Builders<UserMongo>.Filter.Eq(user => user.user_email, "student@hotmail.com"));
                }
            );
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).Milliseconds);
            Console.ReadKey();
        }
    }
}
