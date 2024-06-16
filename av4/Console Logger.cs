using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_log
{
    class Console_Logger : ILogger
    {
        public void LogError(string message)
        {
            Log(message, ConsoleColor.DarkRed);
        }

        public void LogInfo(string message)
        {
            Log(message, ConsoleColor.Magenta);
        }

        private void Log(string message, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.WriteLine($"[{DateTime.Now}]: {message}");
            Console.ResetColor();   
         }

}
}
