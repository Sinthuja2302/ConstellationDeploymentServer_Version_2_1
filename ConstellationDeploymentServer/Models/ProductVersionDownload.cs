using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Models
{
    public class ProductVersionDownload
    {
        public string ID { get; set; }

        public string ProductVersionId { get; set; }

        public string DeviceName { get; set; }

        public string DateDownloaded { get; set; }

        public ProductVersionDownload()
        {

        }

        public ProductVersionDownload(MySqlDataReader reader)
        {
            LoadFromReader(reader);
        }

        public void LoadFromReader(MySqlDataReader reader)
        {
            try
            {
                ID = ReadString(reader, "ID");
                ProductVersionId = ReadString(reader, "ProductVersionId");
                DeviceName = ReadString(reader, "DeviceName");
                DateDownloaded = ReadString(reader, "DateDownloaded");
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
