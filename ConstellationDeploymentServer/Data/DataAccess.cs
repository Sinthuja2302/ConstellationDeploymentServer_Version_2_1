using ConstellationDeploymentServer.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Data
{
    public static class DataAccess
    {
        public static string dbAddress = "127.0.0.1";
        public static bool usingPooling = true;
        public static int poolSize = 20;

        public static string ConnectionString = "server=localhost;user=root;database=constellatindeploymentserver;port=3306;password=moov@123";

        // Example of method to read from database. It calls a procedure and read from the reader and return an Item/List of items
        public static List<Customer> GetCustomers()
        {
           
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                List<Customer> returnList = new List<Customer>();
                conn.Open();
                string sql = "SELECT * FROM constellatindeploymentserver.customer";
                    //"insert into customer (Name, CreatedDate,RootDirectory,IsActive) values ('Arsenal','2021.01.08','D:\fileroot\file2','False')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    returnList.Add(new Customer(reader));
                }
                reader.Close();
                conn.Close();
                conn.Dispose();
                return returnList;
            }
            catch (Exception ex) { return new List<Customer>(); }
        }

        public static List<Customer> GetCustomerById(int id)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                List<Customer> returnList = new List<Customer>();
                conn.Open();
                string sql = "SELECT * FROM customer WHERE id = @id";
                //"insert into customer (Name, CreatedDate,RootDirectory,IsActive) values ('Arsenal','2021.01.08','D:\fileroot\file2','False')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    returnList.Add(new Customer(reader));
                }
                reader.Close();
                conn.Close();
                conn.Dispose();
                return returnList;
            }
            catch (Exception ex) { return new List<Customer>(); }
        }

        // Example of method to Create/Update something. It does not return anything, just call a procedure
        public static List<Customer> CreateCustomer()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                List<Customer> returnList = new List<Customer>();
                conn.Open();
                string sql = "insert into customer(Name, CreatedDate, RootDirectory, IsActive) values('FCBarcelona', '2021.01.05', 'D:\fileroot\file3', 'True')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    returnList.Add(new Customer(reader));
                }
                reader.Close();
                conn.Close();
                conn.Dispose();
                return returnList;
            }
            catch (Exception ex) { return new List<Customer>(); }
        }

        public static List<Customer> UpdateCustomer(int id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString);
                List<Customer> returnList = new List<Customer>();
                conn.Open();
                string sql = "Update customer SET Name = 'WestHamUnited' WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    returnList.Add(new Customer(reader));
                }
                reader.Close();
                conn.Close();
                conn.Dispose();
                return returnList;
            }
            catch (Exception ex) { return new List<Customer>(); }
        }

        //public static string ConnectionString
        //{
        //    get
        //    {
        //        return string.Format("Server={0}; database=ConstellatinDeploymentServer; UID={1}; password={2}; Pooling={3}; MaximumPoolSize={4};allowPublicKeyRetrieval=true;SslMode=None;", dbAddress, "root", "Af6dR4!E4460", (usingPooling ? "True" : "False"), poolSize);

        //    }
        //}


        //// Example of method to read from database. It calls a procedure and read from the reader and return an Item/List of items
        //public static List<Customer> GetCustomers()
        //{
        //    try
        //    {
        //        List<Customer> returnList = new List<Customer>();
        //        MySqlDataReader reader;
        //        using (MySqlConnection conn = new MySqlConnection(ConnectionString))
        //        {
        //            conn.Open();
        //            using (MySqlCommand comm = new MySqlCommand("CDS_GetCustomers"))
        //            {
        //                comm.CommandTimeout = 500;
        //                comm.CommandType = CommandType.StoredProcedure;
        //                comm.Parameters.AddWithValue("", "");
        //                reader = comm.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    returnList.Add(new Customer(reader));
        //                }
        //                reader.Close();
        //            }
        //            conn.Close();
        //            conn.Dispose();
        //        }

        //        return returnList;
        //    }
        //    catch (Exception ex) { return new List<Customer>(); }
        //}



        //Example of method to Create/Update something.It does not return anything, just call a procedure
        //public static void CreateCustomer(Customer c)
        //{
        //    try
        //    {
        //        List<Customer> returnList = new List<Customer>();
        //        using (MySqlConnection conn = new MySqlConnection(ConnectionString))
        //        {
        //            conn.Open();
        //            using (MySqlCommand comm = new MySqlCommand("CDS_CreateCustomer"))
        //            {
        //                comm.CommandTimeout = 500;
        //                comm.CommandType = CommandType.StoredProcedure;
        //                comm.Parameters.AddWithValue("", c.ID);
        //                comm.Parameters.AddWithValue("", c.Name);
        //                comm.Parameters.AddWithValue("", c.CreatedTime);
        //                comm.Parameters.AddWithValue("", c.RootDirectory);
        //                comm.Parameters.AddWithValue("", c.IsActive);
        //                comm.ExecuteNonQuery();

        //            }
        //            conn.Close();
        //            conn.Dispose();
        //        }


        //    }
        //    catch (Exception ex) { }
        //}

    }
}
