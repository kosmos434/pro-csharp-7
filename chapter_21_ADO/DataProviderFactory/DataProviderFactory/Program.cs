using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;

namespace DataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******fun with Data provider factories8888888");
            // get connection string/provider from config file
            string dataProvider =
                ConfigurationManager.AppSettings["provider"];
            string connectionString =
                ConfigurationManager.ConnectionStrings["AutoLotOleDbProvider"].ConnectionString;
            // nbow get the factory provider
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProvider);

            // and then the connection object
            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    ShowError("Connection");
                    return;
                }
                Console.WriteLine("your connection string is : " +
                    connection.GetType().Name);
                connection.ConnectionString = connectionString;
                connection.Open();

                // make the command object
                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    ShowError("Command");
                    return;
                }
                Console.WriteLine("your comand ojbect is a : " +
                    command.GetType().Name);
                command.Connection = connection;
                command.CommandText = "Select * From Inventory";

                // and print ut with data reader
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    Console.WriteLine("your data reader objct is a : "+
                        dataReader.GetType().Name);

                    Console.WriteLine("\n **********current inventory*******");
                    while(dataReader.Read())
                        Console.WriteLine($"--> Car #{dataReader["CarId"]}" +
                            $" is a {dataReader["Make"]}");
                }
            }
            Console.ReadLine();
        }

        private static void ShowError(string objectName)
        {
            Console.WriteLine("there was an error creating the : " + objectName);
            Console.ReadLine();
        }
    }
}
