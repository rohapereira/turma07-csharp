using System;
using System.IO;

namespace web_api_05.Configurations
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