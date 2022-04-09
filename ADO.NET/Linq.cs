    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ADO.NET
    {
        class Linq
        {
        public  List<LineItems> lineitems; 
            private static void OpenSqlConnection()
            {
                string connectionString = GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                

                string query = string.Format("select * from PoDetail where PONumber = 'AS34RD44WXD' ");

                SqlCommand SelectCommand = new SqlCommand(query, connection);

                SelectCommand.CommandTimeout = 60;

                try
                {
                    connection.Open();

                    Console.WriteLine("Connection Opened Sucessfully");

                    SelectCommand.CommandText = query;

                    SqlDataReader dr = SelectCommand.ExecuteReader(CommandBehavior.SingleResult);

                    dr.Read();
                    string PONumer = dr[0].ToString();
                    string TransactionId = dr[1].ToString();
                    string LineItemId = dr[2].ToString();
                                                      string Source = dr[3].ToString();
                                                          bool NSPR = (bool)dr[4]; 
                        
                        
                        
                        
                    LineItems lineitems = new LineItems {PONumer = PONumer,
                                                         TransactionId = TransactionId,
                                                           LineItemId = LineItemId,
                                                           Source = Source,
                                                           NSPR = NSPR
                    };

                    
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                bool isNSPR = LineItems.
                Console.WriteLine(isNSPR);

                    connection.Close();
                    Console.WriteLine("Connection Closed Sucessfully");
                }
            }

            private static string GetConnectionString()
            {

                return @"data source=COGNINE-L94\VENKATESH; database=Linq; Initial Catalog = Linq; Integrated Security=True";
            }

            static void Main()
            {
                OpenSqlConnection();
            }

        }
            public class LineItems
            {
                public string PONumer { set; get; }

                public string TransactionId { set; get; }

                public string LineItemId { set; get; }

                public string Source { set; get; }

                public bool NSPR { get; set; }


            }
    }



