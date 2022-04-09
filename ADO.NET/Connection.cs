using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO.NET
{
    public class Connection
    {
        //private static void OpenSqlConnection()
        //{
        //    string connectionString = GetConnectionString();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        Console.WriteLine("Connection Opened Sucessfully");
        //        connection.Close();
        //        Console.WriteLine("Connection Closed Sucessfully");
        //    }
        //}

        // private static string GetConnectionString()
        //{

        //    return @"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True";
        //}
        static void Main(string[] args)
        {
            //OpenSqlConnection();

            Console.WriteLine("Connection Establish");
            try
            {
                SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

                Console.WriteLine("got connection string");

                conn.Open();

                Console.WriteLine("Connection Open!");


                conn.Close();

                Console.WriteLine("Connection Close!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Console.WriteLine("Connection Established");
            //try
            //{
            //    var con = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            //    Console.WriteLine("got connection string");

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}



        }

    }
}


