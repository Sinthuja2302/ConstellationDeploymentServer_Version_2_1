using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Models
{
    public class Customer
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string CreatedTime { get; set; }

        public string RootDirectory { get; set; }

        public bool IsActive { get; set; }


        // In case we need to create a new object from scratch (without DB data)
        public Customer() { }


        // When reading from the DB
        public Customer(MySqlDataReader reader)
        {
            LoadFromReader(reader);
        }

        public void LoadFromReader(MySqlDataReader reader)
        {
            try
            {
                ID = ReadString(reader, "ID");
                Name = ReadString(reader, "Name");
                CreatedTime = ReadString(reader, "CreatedTime");
                RootDirectory = ReadString(reader, "RootDirectory");
                IsActive = ReadBool(reader, "IsActive");
            }
            catch (Exception ex) { }
        }

        public string ReadString(MySqlDataReader reader, string name)
        {
            string result = "";
            try
            {
                result = Convert.ToString(reader[name]);
            }
            catch (Exception e)
            {

            }
            return result;
        }
        //public int ReadInt(MySqlDataReader reader, string name)
        //{
        //    int result = 0;
        //    try
        //    {
        //        result = Convert.ToInt32(reader[name].ToString());
        //    }
        //    catch (Exception ex) { }
        //    return result;
        //}
        public bool ReadBool(MySqlDataReader reader, string name)
        {
            bool result = false;
            try
            {
                result = Convert.ToBoolean(reader[name].ToString());
            }
            catch (Exception ex) { }
            return result;
        }
    }
}
