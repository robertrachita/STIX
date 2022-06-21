//using System;
using System.Data.SqlClient;
//using System.Globalization;
/*using System.Data.Odbc;
using System.Data.OleDb;*/

string conn = "Data Source = CHRISTO\\SQLEXPRESS; Initial Catalog = Netflix; Integrated Security = True";

using (SqlConnection connection = new SqlConnection(conn))
{
    try
    {
        connection.Open();
        DateTime start = DateTime.Now;

        DateTime end = DateTime.Now;
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}