using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Models
{
    public class ProductVersionMode
    {
        public string ID { get; set; }

        public string ProductVersionId { get; set; }

        public string ModeName { get; set; }

        public ProductVersionMode()
        {

        }

        public ProductVersionMode(MySqlDataReader reader)
        {
            LoadFromReader(reader);
        }

        public void LoadFromReader(MySqlDataReader reader)
        {
            try
            {
                ID = ReadString(reader, "ID");
                ProductVersionId = ReadString(reader, "ProductVersionId");
                ModeName = ReadString(reader, "ModeName");
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
            catch (Exception ex) { }
            return result;
        }
    }
}
