using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Vytas Gadliauskas  added logins (exceptions output to log file)
namespace SessionManagement
{
    internal class Logs
    {
        public static void writeLog(string message)
        {
            DateTime localDate = DateTime.Now;
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            using (StreamWriter outputFile = File.AppendText(Path.Combine(strWorkPath, "MPManagerSecure.log")))
            {
                outputFile.WriteLine(localDate.Year + "-" + localDate.Month + "-" + localDate.Day + "_" +
                                      localDate.Hour + ":" + localDate.Minute + ":" + localDate.Second + " " + message);
            }
        }
    }
}

