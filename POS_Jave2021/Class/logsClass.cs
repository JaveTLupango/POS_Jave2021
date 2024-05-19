using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Jave2021.Class
{
    public class logsClass
    {
        public static string _logPath;
        public static string _filename;
        public logsClass()
        {
            _logPath = ConfigurationManager.AppSettings["logspath"];
            _filename = "" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            
            if (!File.Exists(_logPath + _filename))
            {
                File.Create(_logPath + _filename).Dispose();
            }
        }
        public void writelineLogs(string logs)
        {

            File.AppendAllText(_logPath + _filename,
                DateTime.Now.ToString("yyyyMMdd-HHmmss : ") +
                logs + Environment.NewLine);

            //using (StreamWriter writer = new StreamWriter(_logPath + _filename))
            //{
            //    writer.wh(logs);
            //}
        }
    }
}
