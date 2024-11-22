using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

////  Vytas Gadliauskas  XWindows start 
namespace SessionManagement
{
    internal class XWindows
    {

        public static void connect(Session session) 
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strTempConfigFileName = string.Format(@"{0}.txt", Guid.NewGuid());
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string fileName = Path.Combine(strWorkPath, strTempConfigFileName);

            string username;
            string password;

            if (!"".Equals(session.vcXsrvUserName) && !"".Equals(session.vcXsrvPassword))
            {
                username = session.vcXsrvUserName;
                password = session.vcXsrvPassword;
            }
            else 
            {
                username = session.sessionUserName;
                password = session.sessionPassword;
            }

            if (!File.Exists(Global.strVcXsrvLocation))
            {
                MessageBox.Show("Xlaunch.exe file does not exist. Go to Tools -> Options... to configure XWindows");
            }
            else
            {
                try
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {

                        outputFile.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                        outputFile.WriteLine("<XLaunch WindowMode=\"MultiWindow\" ClientMode=\"StartProgram\" " +
                            "LocalClient=\"False\" Display=\"-1\" LocalProgram=\"xcalc\" RemoteProgram=\"xterm\" " +
                            "RemotePassword=\""+ password +"\" PrivateKey=\"\" " +
                            "RemoteHost=\""+ session.sessionHost +"\" " +
                            "RemoteUser=\""+ username +"\" " +
                            "XDMCPHost=\"\" XDMCPBroadcast=\"False\" XDMCPIndirect=\"False\" Clipboard=\"True\" " +
                            "ClipboardPrimary=\"True\" ExtraParams=\"\" Wgl=\"True\" DisableAC=\"False\" XDMCPTerminate=\"False\"/>\r\n");
                    }
                    string str = " -run " + fileName;
                    Process process = Process.Start(new ProcessStartInfo(Global.strVcXsrvLocation)
                    {
                        Arguments = str,
                        UseShellExecute = false,
                        CreateNoWindow = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    });
                }
                 catch (Exception ex)
                {
                    // Vytas Gadliauskas added exception logging
                    Logs.writeLog(ex.Message);
                }
                finally
                {
                    Thread.Sleep(1000);
                    File.Delete(fileName);
                }
            }
        }
    }
}
