using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    class Create
    {
        static void Main(String[]args)
        {
            SqlConnection conn = new SqlConnection(@"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True");

            string query = @"Create Table ADOTABLE_1( ID int Identity(1,1) Primary Key ,Name nvarchar(300) not null,Record_Added_Time datetime not null)";

            SqlCommand CreateCommand = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                Console.WriteLine("Connection Opened Sucessfully");

                CreateCommand.ExecuteNonQuery();

                Console.WriteLine("Table Created Successfully");

                conn.Close();

                Console.WriteLine("Connection Closed Sucessfully");

                Console.ReadKey();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
