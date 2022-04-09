using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Select
    {
        static void Main()
        {
            SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

            string query = string.Format("select * from ADOTABLE_1 ");

            SqlCommand SelectCommand = new SqlCommand(query, conn);

            SelectCommand.CommandTimeout = 60;

            int count2;

            try
            {
                conn.Open();

                Console.WriteLine("Connection Opened Sucessfully");

                SelectCommand.CommandText = "Select Count(ID) From ADOTABLE_1";

                int count = (int)SelectCommand.ExecuteScalar();

                SelectCommand.CommandText = query;

                SqlDataReader dr = SelectCommand.ExecuteReader(CommandBehavior.SingleResult);

                while (count >= 0)
                {
                    count2 = (count >= 10) ? 10 : count;

                    for (int i = 1; i <= count2; i++)
                    {

                        dr.Read();

                        Console.WriteLine("ID: {0} \t Name: {1} \t Record_Added_Time: {2} \t \n", dr[0], dr[1], dr[2]);

                    }

                    count = count - 10; 
                    
                    Thread.Sleep(10000);

                }
                
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


