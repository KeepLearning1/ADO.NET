using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Delete
    {
        static void Main()
        {
            string Name = Console.ReadLine();

            int ID = Convert.ToInt32(Console.ReadLine());

            Name = "'" + Name + "'";

            SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

            string query = string.Format("DELETE  FROM ADOTABLE_1 WHERE Name ={0} AND ID ={1} ", Name, ID);

            SqlCommand DeleteCommand = new SqlCommand(query, conn);

            DeleteCommand.CommandTimeout = 60;


            try
            {
                conn.Open();

                Console.WriteLine("Connection Opened Sucessfully");

                DeleteCommand.ExecuteNonQuery();

                Console.WriteLine("Deleted Successfully");

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
