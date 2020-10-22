using System;
using System.Data;
// use a config file to update the Main()
// programatically. Changes provider.
using System.Configuration;

// needed to get definitions of common interfaces
// and connection objects!!
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace MyConnectionFactory
{
    class Program
    {
        // enum of possible provider names
        enum DataProvider
        {
            SqlServer, OleDb, Odbc, None
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------simple connection factory-------");
            // lets read in from the config
            string dataProviderString = ConfigurationManager.AppSettings["provider"];
            // turn string into enum
            DataProvider dataProvider = DataProvider.None;
            if (Enum.IsDefined(typeof (DataProvider), dataProviderString))
            {
                dataProvider = (DataProvider)Enum.Parse(typeof(DataProvider), dataProviderString);
            }
            else
            {
                Console.WriteLine("no provider exists");
                Console.ReadLine();
                return;
            }

            // get a specific conenciotn
            IDbConnection myConnection = GetConnection(DataProvider.SqlServer);
            Console.WriteLine($"your connection is {myConnection.GetType().Name}");
            // open, use and close conncetion.
            Console.ReadLine();
        }


        // method that returns a specific connection object
        // based on the value of a DataProvider enum
        static IDbConnection GetConnection(DataProvider dataProvider)
        {
            IDbConnection connection = null;
            switch (dataProvider)
            {
                case DataProvider.SqlServer:
                    connection = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    connection = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    connection = new OdbcConnection();
                    break;
            }
            return connection;
        }
    }
}
