﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstellationDeploymentServer.Models
{
    public class LauncherVersion
    {
        public string ID { get; set; }

        public string VersionName { get; set; }

        public string Description { get; set; }

        public string ReleaseNote { get; set; }

        public string ReleasedBy { get; set; }

        public bool IsDownloadable { get; set; }

        public bool IsLatest { get; set; }

        public LauncherVersion()
        {

        }

        public LauncherVersion(MySqlDataReader reader)
        {
            LoadFromReader(reader);
        }

        public void LoadFromReader(MySqlDataReader reader)
        {
            try
            {
                ID = ReadString(reader, "ID");
                VersionName = ReadString(reader, "VersionName");
                Description = ReadString(reader, "Description");
                ReleaseNote = ReadString(reader, "ReleaseNote");
                ReleasedBy = ReadString(reader, "ReleasedBy");
                IsDownloadable = ReadBool(reader, "IsDownloadable");
                IsLatest = ReadBool(reader, "IsLatest");
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

        public bool ReadBool(MySqlDataReader reader, string name)
        {
            bool result = false; ;
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
