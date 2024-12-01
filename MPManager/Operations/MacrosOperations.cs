using SessionManagement.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace SessionManagement.Operations
{
    // Vytas Gadliauskas Macros support
    // Macros stored in "exe path"\macros.txt file  name:commands format 
    // 
    internal static class MacrosOperations
    {
        public static Dictionary<string, Macros> macrosList = new Dictionary<string, Macros>();
        public static string macros { get; set; }

        public static void loadMacrosFromXMLDatabase() 
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(getFileName()))
                {
                    string ln;
                    while ((ln = inputFile.ReadLine()) != null)
                    {
                        int pos = ln.IndexOf(':');
                        macrosList.Add(ln.Substring(0,pos), new Macros(ln.Substring(0,pos), ln.Substring(pos+1)));
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.writeLog(ex.Message);
            }
        }

        public static void saveMacrosToXMLDatabase()
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(getFileName()))
                {
                    foreach (Macros macros in macrosList.Values)
                    {
                        outputFile.WriteLine(macros.name + ":" + macros.commands);
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.writeLog(ex.Message);  
            }
        }

        public static void addMacroToList(Macros macros) 
        {
            if (macros != null)
            {
                if (!"".Equals(macros.name))
                {
                    if (macrosList.ContainsKey(macros.name))
                    {
                        editMacrosInList(macros);
                    }
                    else
                    {
                       macrosList[macros.name] = macros; 
                    }
                }
            }
        }

        public static string getMacroFromList(string key)
        {
            if (macrosList.ContainsKey(key)) { 
                 return macrosList[key].commands;  
            }
            return "";
        }

        public static void deleteMacroFromList(string key) 
        {
            if (macrosList.ContainsKey(key)) macrosList.Remove(key);
        }

        public static void editMacrosInList(Macros macros) {
            if (macros != null) 
            {
                if (!"".Equals(macros.name) && macros.name != null)
                {
                    macrosList.Remove(macros.name);
                    macrosList.Add(macros.name, macros);
                }
            }
        }

        public static string[] getmacrosNames() 
        {
            return macrosList.Keys.ToArray(); ;
        }

        private static string getFileName() 
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return System.IO.Path.GetDirectoryName(strExeFilePath) + "\\" + "macros.txt";
        }
    }
}
