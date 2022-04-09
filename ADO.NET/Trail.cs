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
    class Trail
    {

        private string GetConnectionString()
        {
            return @"data source=COGNINE-L94\VENKATESH; database=ADO_DOT_NET; Initial Catalog = ADO_DOT_NET; Integrated Security=True";
        }
        static void Main()
        {
            string ConnectionString =  new Trail().GetConnectionString();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                conn.CreateCommand();

                conn.Close();

            }

             
        }
    }
}
