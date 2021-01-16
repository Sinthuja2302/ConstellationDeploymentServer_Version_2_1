using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Models
{
    public class Product
    {
        public string ID { get; set; }

        public string ProductName { get; set; }

        public string CustomerId { get; set; }

        public string CreatedDate { get; set; }

        public string LastUpdatedDate { get; set; }

        public string ProductDirectory { get; set; }

        public bool IsActive { get; set; }

        public Product() { }


        public Product(MySqlDataReader reader)
        {
            LoadFromReader(reader);
        }

        public void LoadFromReader(MySqlDataReader reader)
        {
            try
            {
                ID = ReadString(reader, "ID");
                ProductName = ReadString(reader, "ProductName");
                CustomerId = ReadString(reader, "CustomerId");
                CreatedDate = ReadString(reader, "CreatedDate");
                LastUpdatedDate = ReadString(reader, "LastUpdatedDate");
                ProductDirectory = ReadString(reader, "ProductDirectory");
                IsActive = ReadBool(reader, "IsActive");
            }
            catch (Exception ex)
            {

            }
        }

        public string ReadString(MySqlDataReader reader, string name)
        {
            string result = "";
            try
            {
                result = Convert.ToString(reader[name]);
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public bool ReadBool(MySqlDataReader reader, string name)
        {
            bool result = false;
            try
            {
                result = Convert.ToBoolean(reader[name].ToString());
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
