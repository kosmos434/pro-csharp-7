using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add this stuff
using System.Data;
using System.Data.SqlClient;
// this is for the strongly typed InsertAuto(Car car) method
using AutoLotDAL.Models;
using System.Data.SqlTypes;

namespace AutoLotDAL.DataOperations
{
    public class InventoryDAL
    {
        // Class level variables
        private SqlConnection _sqlConnection = null;
        private readonly string _connectionString;

        // Ctors, note the chaining
        // so an empty instance would always have this
        // thrown to the other ctor
        public InventoryDAL() : this(
            @"Data Source = (localdb)\mssqllocaldb;
            Integrated Security=true;
            Initial Catalog=AutoLot")
        {
        }
        // or use the connecitn strgin we provide
        public InventoryDAL(string connectionString)
            => _connectionString = connectionString;



        // Methods
        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection { ConnectionString = _connectionString };
            _sqlConnection.Open();
        }
        private void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }

        public List<Car> GetAllInventory()
        {
            OpenConnection();
            // This will hold the records.
            List<Car> inventory = new List<Car>();

            // Prep command object.
            string sql = "Select * From Inventory";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    inventory.Add(new Car
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    });
                }
                dataReader.Close();
            }
            return inventory;
        }

        public Car GetCar(int id)
        {
            OpenConnection();
            Car car = null;
            // this is where the id goes in
            string sql = $"Select * From Inventory where CarId = {id}";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                while (dataReader.Read())
                {
                    car = new Car
                    {
                        CarId = (int)dataReader["CarId"],
                        Color = (string)dataReader["Color"],
                        Make = (string)dataReader["Make"],
                        PetName = (string)dataReader["PetName"]
                    };
                }
                dataReader.Close();
            }
            return car;
        }

        // takes in three string values, the CarId is identity so it's good
        public void InsertAuto(string color, string make, string petName)
        {
            OpenConnection();
            // now format and execute sql statement
            string sql = $"Insert Into Inventory (Make, Color, PetName) " +
                $"Values ('{make}', '{color}', '{petName}')";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        // better yet, use a class
        // and let's paramaterize our sql query
        public void InsertAuto(Car car)
        {
            OpenConnection();
            // now format and execute sql statement
            string sql = "Insert Into Inventory" +
                         "(Make, Color, PetName) Values" +
                         "(@Make, @Color, @PetName)";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Make",
                    Value = car.Make,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Color",
                    Value = car.Color,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@PetName",
                    Value = car.PetName,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void DeleteCar(int id)
        {
            OpenConnection();
            // get ID of car to delete, then delte!
            string sql = $"DELETE FROM Inventory WHERE CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    Exception error = new Exception("oops that car is on order", ex);
                    throw error;
                }
            }
            CloseConnection();
        }

        public void UpdateCarPetName(int id, string newPetName)
        {
            OpenConnection();
            // get id of car to change, then change!
            string sql = $"UPDATE Inventory SET PetName = '{newPetName} " +
                $"WHERE CarId = '{id}'";
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        // exec a stored procedure
        public string LookUpPetName(int carId)
        {
            OpenConnection();
            string carPetName;

            // Establish name of stored proc.
            using (SqlCommand command = new SqlCommand("GetPetName", _sqlConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Input param.
                SqlParameter param = new SqlParameter
                {
                    ParameterName = "@carId",
                    SqlDbType = SqlDbType.Int,
                    Value = carId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(param);

                // Output param.
                param = new SqlParameter
                {
                    ParameterName = "@petName",
                    SqlDbType = SqlDbType.Char,
                    Size = 10,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(param);

                // Execute the stored proc.
                command.ExecuteNonQuery();

                // Return output param.
                carPetName = (string)command.Parameters["@petName"].Value;
                CloseConnection();
            }
            return carPetName;
        }

        public void ProcessCreditRisk(bool throwEx, int custId)
        {
            OpenConnection();
            // look up current name based on custid
            string fName;
            string lName;
            var cmdSelect =
                new SqlCommand($"Select * from Customers where CustId = {custId}",
                    _sqlConnection);
            using (var dataReader = cmdSelect.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    fName = (string)dataReader["FirstName"];
                    lName = (string)dataReader["LastName"];
                }
                else
                {
                    CloseConnection();
                    return;
                }
            }

            // create command objects that represent each step of the operation
            var cmdRemove =
                new SqlCommand($"Delete from Customers where CustId = {custId}",
                    _sqlConnection);

            var cmdInsert =
                new SqlCommand("Insert Into CreditRisks" +
                               $"(FirstName, LastName) Values('{fName}', '{lName}')",
                    _sqlConnection);

            // get this from the connection object
            SqlTransaction tx = null;
            try
            {
                tx = _sqlConnection.BeginTransaction();

                // enlist te commands into this transaction
                cmdInsert.Transaction = tx;
                cmdRemove.Transaction = tx;

                // and execute the commands
                cmdInsert.ExecuteNonQuery();
                cmdRemove.ExecuteNonQuery();

                // simulate an error?? based on the bool we input
                if (throwEx)
                {
                    throw new Exception("sowwy, database erroe! tx failed");
                }

                // and commit it if there's no error
                tx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tx?.Rollback();
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
