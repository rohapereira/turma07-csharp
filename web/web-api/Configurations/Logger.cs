using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace web_api.Configurations
{
    public class Logger
    {
        private static string getpath()
        {
            return System.Configuration.ConfigurationManager.AppSettings["caminhoLog"];
        }

        private static string getArchieveName()
        {
            return $"{DateTime.Now.ToString("yyyy-MM-dd")}.txt";
        }

        public static string getFullPath()
        {
            return Path.Combine(getpath() + getArchieveName());
        }
    }
}