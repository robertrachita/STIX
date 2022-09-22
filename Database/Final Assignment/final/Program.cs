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
            string conn = "Data Source = .\\SQLEXPRESS; Initial Catalog = Netflix; Integrated Security = True";
            //AdoNet.AdoRead(5);
            //AdoNet.AdoInsert(2);
            //AdoNet.AdoUpdate(2);
            //AdoNet.AdoDelete(1);



            /*SubscriptionEntity subscription = new SubscriptionEntity();
            subscription.subscription_id = 99;
            UserEntity newUser = new UserEntity();
            newUser.user_email = "momchill@gmail.com";
            newUser.subscription_id = 2;
            newUser.login_attempts = 0;
            EntityFramework.EfUpdate(4);
            */
            //NoSQL.insert(3);
            NoSQL.updateByEmailName(2);
            //NoSQL.updateByEmailName(1);
            //MongoDB.updateByEmailName(2);
            //Console.WriteLine("Succesful");

            Console.ReadKey();
        }
    }
}
