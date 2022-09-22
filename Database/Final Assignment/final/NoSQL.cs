using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using final.Model;
using System.Text.RegularExpressions;

namespace final
{
    static class NoSQL
    {
        public static MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase database = mongoClient.GetDatabase("Stix");
        public static IMongoCollection<UserMongo> collection = database.GetCollection<UserMongo>("User");

        public static void insert(int rows)
        {
            if (rows < 1)
            {
                return;
            }

            UserMongo user = new UserMongo();
            user.user_email = "victor@gmail.com";
            user.user_password = "pwd123";
            if (rows == 1)
            {
                collection.InsertOneAsync(user);
                return;
            }
            List<UserMongo> list = new List<UserMongo>();
            for (int i = 0; i < rows; i++)
            {
                user = new UserMongo();
                user.user_email = "Victor" + i + "@gmail.com";
                user.user_password = "123" + i;
                list.Add(user);
            }
            collection.InsertManyAsync(list);
        }

        public static void read(int rows)
        {
            if (rows < 1)
            {
                return;
            }
            try
            {
                var results = collection.Find(_ => true).Limit(rows).ToList();
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void updateByEmailName(int rows)
        {
            if (rows < 1)
            {
                return;
            }
            collection.Find(_ => true).Limit(rows).ForEachAsync(docs =>
            {
                collection.UpdateOneAsync(Builders<UserMongo>.Filter.Regex("user_email", new BsonRegularExpression((new Regex("chris@gmail.com", RegexOptions.IgnoreCase)))), Builders<UserMongo>.Update.Set("user_email", "VictorTromp@hotmail.com"));
            });

        }

        public static void delete(int rows)
        {
            if (rows > 0)
            {
                if (rows == 1)
                {
                    collection.DeleteOneAsync(Builders<UserMongo>.Filter.Empty);
                    return;
                }
                collection.Find(_ => true).Limit(rows).ForEachAsync(
                        docs =>
                        {
                            collection.DeleteOne(Builders<UserMongo>.Filter.Empty);
                        }
                    );
            }
        }

        public static void listDB()
        {
            var dbList = mongoClient.ListDatabases().ToList();
            Console.WriteLine("The list of databases on this server are :");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }
    }
}
