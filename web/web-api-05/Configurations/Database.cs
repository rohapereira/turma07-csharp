using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api_05.Configurations
{
    public class Database
    {
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["almoxerifado"].ConnectionString;
        }
    }
}