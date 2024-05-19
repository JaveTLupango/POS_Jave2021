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
        string _logPath;
        string __filename;
        public logsClass()
        {
            _logPath = ConfigurationManager.AppSettings["logspath"];
            __filename = "\\"+DateTime.Now.ToString("yyyyMMdd")+".txt";
        }

        public void validateFile()
        {
            if (File.Exists(_logPath+ __filename))
            {

            }
        }

    }
}
