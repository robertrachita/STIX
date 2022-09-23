using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using final.Model;
using System.IO;
using System.Threading;

namespace final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = "Data Source = .\\SQLEXPRESS; Initial Catalog = Netflix; Integrated Security = True";
            string testNumber, variableNumber;
            int variableNumberInt;

            Console.WriteLine("Test 1 => Ado.Net \nTest 2 => Entity Framework \nTest 3 => MongoDB \n");
            Console.WriteLine("Enter the number of the test you want to run: ");
            testNumber = Console.ReadLine();
            if (testNumber != "1" || testNumber != "2" || testNumber != "3")
            {
                Console.WriteLine("Invalid test number, the program will close automatcally in 2 seconds");
                Thread.Sleep(2000);
                return;
            }
            Console.WriteLine("Enter how many tests(entries) you want to run: ");
            variableNumber = Console.ReadLine();
            variableNumberInt = Convert.ToInt32(variableNumber);

            switch (testNumber)
            {
                case "1":
                    AdoNet.AdoRead(variableNumberInt);
                    AdoNet.AdoInsert(variableNumberInt);
                    AdoNet.AdoUpdate(variableNumberInt);
                    AdoNet.AdoDelete(variableNumberInt);
                    break;
                case "2":
                    SubscriptionEntity subscription = new SubscriptionEntity();
                    subscription.subscription_id = 99;
                    UserEntity newUser = new UserEntity();
                    newUser.user_email = "momchill@devgmail.com";
                    newUser.subscription_id = 2;
                    newUser.login_attempts = 0;
                    EntityFramework.EfUpdate(variableNumberInt);
                    break;
                case "3":
                    NoSQL.insert(variableNumberInt);
                    NoSQL.updateByEmailName(2);
                    NoSQL.updateByEmailName(1);
                    break;
                default:
                    Console.WriteLine("Invalid test number");
                    break;
            }


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
