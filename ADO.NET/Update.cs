using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Update
    {
        static void Main()
        {
            string Name = Console.ReadLine();

            int ID = Convert.ToInt32(Console.ReadLine());

            Name = "'" + Name + "'";

            SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

            string query = string.Format("Update ADOTABLE_1 set Name ={0} Where ID ={1} ",Name,ID);

            SqlCommand UpdateCommand = new SqlCommand(query, conn);

            UpdateCommand.CommandTimeout = 60;


            try
            {
                conn.Open();

                Console.WriteLine("Connection Opened Sucessfully");

                UpdateCommand.ExecuteNonQuery();

                Console.WriteLine("Updated Successfully");

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
