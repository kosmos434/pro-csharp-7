using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Console;

namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******fun with this shite*********");


            // lets use connectionstringbulder tho
            var cnStringBuilder = new SqlConnectionStringBuilder
            {
                InitialCatalog = "AutoLot",
                DataSource = @"(localdb)\mssqllocaldb",
                ConnectTimeout = 30,
                IntegratedSecurity = true
            };


            // createa and open a conneciton
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = cnStringBuilder.ConnectionString;
                connection.Open();
                ShowConnectionStatus(connection);

                // create a sql command object
                //string sql = "Select * From Inventory;";
                string sql = "Select * From Inventory;Select * From Customers";
                SqlCommand myCommand = new SqlCommand(sql, connection);

                // objtain a data reader a la ExecuteReader()
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    // loop over and read
                    do
                    {
                        while (myDataReader.Read())
                        {
                            WriteLine("***** Record *****");
                            for (int i = 0; i < myDataReader.FieldCount; i++)
                            {
                                WriteLine($"{myDataReader.GetName(i)} = {myDataReader.GetValue(i)}");
                            }
                            WriteLine();
                        }
                    } while (myDataReader.NextResult());
                }
            }
            Console.ReadLine();
        }

        static void ShowConnectionStatus(SqlConnection connection)
        {
            // Show various stats about current connection object.
            Console.WriteLine("***** Info about your connection *****");
            Console.WriteLine($"Database location: {connection.DataSource}");
            Console.WriteLine($"Database name: {connection.Database}");
            Console.WriteLine($"Timeout: {connection.ConnectionTimeout}");
            Console.WriteLine($"Connection state: {connection.State}\n");
        }
    }
}
