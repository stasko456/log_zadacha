using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    public class LogTXT : ILog
    {
        private string pathOfFile = "log.txt";
        public void Log(string message)
        {
            File.AppendAllText(pathOfFile, message);
        }
    }
}