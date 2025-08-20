using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MiniHotel.Common
{
    public static class ConfigHelper
    {
        public static string GetConnectionString(string name = "HotelMiniContext")
        {
            //var conn = ConfigurationManager.ConnectionStrings[name];
            var conn = ConfigurationManager.ConnectionStrings[name];
            if (conn == null)
            {
                throw new Exception($"Connection string '{name}' not found in App.config");
            }
            return conn.ConnectionString;
        }
    }
}
