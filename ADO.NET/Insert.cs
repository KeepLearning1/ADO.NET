using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Insert
    {
        static void Main(String [] args)
        {
            SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

            String Name = Console.ReadLine();

            DateTime Record_Added_Time = DateTime.Now;

            string query = @"Insert Into ADOTABLE_1(Name,Record_Added_Time) Values(@Name,@Record_Added_Time) ";

            SqlCommand InsertCommand = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                Console.WriteLine("Connection Opened Sucessfully");

                InsertCommand.Parameters.AddWithValue("@Name", Name);

                InsertCommand.Parameters.AddWithValue("@Record_Added_Time", Record_Added_Time);

                InsertCommand.ExecuteNonQuery();

                Console.WriteLine("Inserted Successfully");

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

