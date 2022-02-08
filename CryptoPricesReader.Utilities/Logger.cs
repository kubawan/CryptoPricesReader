using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPricesReader.Utilities
{
    public static class Logger
    {
        private static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string AppName = "CryptoPricesViewer";
        
        private static object _locker = new object();

        public static void LogInfoToFile(string fileName, string msg)
        {
            WriteMsgToFile(fileName, $"INFO: {DateTime.Now.ToString("HH:mm:ss:ffffff")} MSG: {msg}");
        }

        private static void WriteMsgToFile(string fileName, string msg)
        {
            string path = @$"{FolderPath}\{AppName}\{DateTime.Now.ToString("yyyy-MM-dd")}";

            lock(_locker)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (!File.Exists(@$"{path}\{fileName}"))
                {
                    File.WriteAllText(@$"{path}\{fileName}", msg);
                }
                else
                {
                    File.AppendAllText(@$"{path}\{fileName}", $"\n{msg}");
                }
            }
        }
    }
}
