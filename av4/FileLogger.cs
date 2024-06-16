using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_log
{
    internal class FileLogger : ILogger
    {
        public string Filename { get; private set; }
        public FileLogger(string filename){
            Filename = filename;
         }

    public void LogError(string message)
        {
           Log($"Err {message}");
        }

        public void LogInfo(string message)
        {
            Log($"Inf {message}");
        }
        private void Log(string message) {
            using (var writer = new StreamWriter(Filename, true))
                 {
                 writer.WriteLine($"[{DateTime.Now}]: {message}");
                 }
        }
    }
}
