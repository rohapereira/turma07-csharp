using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace web_api.Util
{
    public class Logger
    {
        public static void WriteException(string fullPath, Exception e)
        {
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.Write("Data:");
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                sw.Write("Mensagem:");
                sw.WriteLine(e.Message);
                sw.Write("StackTrace");
                sw.WriteLine(e.StackTrace + "\n");
            }
        }
    }
}