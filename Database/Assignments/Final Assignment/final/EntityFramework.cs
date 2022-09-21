using final.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    static class EntityFramework
    {
        public static DateTime before;
        public static DateTime after;
        public static DatabaseContext _context;
 
        // insert x amount of rows
        public static void EfInsert(int rows, UserEntity user) 
        {
            SubscriptionEntity subscriptionEntity = new SubscriptionEntity();
            subscriptionEntity.subscription_id = 1;


            try
            {
                Console.WriteLine("----------* Inserting " + rows +" rows of data");
                using (_context = new DatabaseContext())
                {
                    before = DateTime.Now;
                    List<UserEntity> list = new List<UserEntity>();
                    if (rows > 0) 
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            list.Add(user);
                        }
                        _context.Configuration.AutoDetectChangesEnabled = false;
                        _context.Configuration.ValidateOnSaveEnabled = false;

                        _context.Users.AddRange(list);
                        _context.SaveChanges();
                    }
                    after = DateTime.Now;
                }
                Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Read x amount of rows
        public static void EfRead(int rows) 
        {
            Console.WriteLine("----------* Reading " + rows + " rows of data");
            before = DateTime.Now;
            using (var dbContext = new DatabaseContext())
            {
                if (rows <= 0) 
                {
                    Console.WriteLine("No rows selected");
                }

                //might be redundant
                if (rows == 1)
                {
                    string query = "SELECT * FROM [dbo].[User]";
                    var result = dbContext.Users.SqlQuery(query).First();
                }
                else 
                {
                    var user1 = (from user2 in dbContext.Users
                                 select user2).Take(rows);
                }
            }
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
        }

        // update x amount of rows
        public static void EfUpdate(int rows) 
        {
            Console.WriteLine("----------* Updating" + rows + "rows of data");
            before = DateTime.Now;
            using (var dbContext = new DatabaseContext())
            {
                if (rows > 0) 
                {
                    var user1 = (from user2 in dbContext.Users
                                 select user2).Take(rows);
                    foreach (var entity in user1)
                    {
                        entity.user_password = "abcd123";
                    }
                    dbContext.SaveChanges();
                }
            }
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
        }

        // delete x amount of rows
        public static void EfDelete(int rows) 
        {
            Console.WriteLine("----------* Deleting "+ rows + " rows of data");
            before = DateTime.Now;
            using (var dbContext = new DatabaseContext())
            {
                if (rows > 0) 
                {
                    var testing = (from e in dbContext.Users
                                   select e).Take(rows);
                    dbContext.Configuration.AutoDetectChangesEnabled = false;
                    dbContext.Configuration.ValidateOnSaveEnabled = false;
                    dbContext.Users.RemoveRange(testing);
                    dbContext.SaveChanges();
                }
            }
            after = DateTime.Now;
            Console.WriteLine("Duration in miliseconds: {0}", (after - before).TotalMilliseconds);
        }
    }
}
