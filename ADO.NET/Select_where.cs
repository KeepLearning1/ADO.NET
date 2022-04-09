using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Select_where
    {
        static void Main()
        {
            SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

            String Name = Console.ReadLine();

            string str = "'" + Name + "'";

            string query =  string.Format("select * from ADOTABLE_1 where Name = {0} ", str); 

            SqlCommand SelectCommand = new SqlCommand(query, conn);

             SelectCommand.CommandTimeout = 60;

            try
            {
                conn.Open();

                Console.WriteLine("Connection Opened Sucessfully");

                SelectCommand.CommandText = query;

                SqlDataReader dr = SelectCommand.ExecuteReader(CommandBehavior.SingleResult);

                dr.Read();

                Console.WriteLine("ID: {0} \t Name: {1} \t Record_Added_Time: {2} \t ", dr[0],dr[1],dr[2]);

                Console.WriteLine("Selected Successfully");

                conn.Close();

                Console.WriteLine("Connection Closed Sucessfully");

                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    
}
