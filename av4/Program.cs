using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_log
{
     class Program
    {
        static void Main(string[] args)
        {
            string logFile = "logs.txt";
            ILogger[] loggers = new ILogger[]
            {
                new Console_Logger(),
                new FileLogger(logFile),

            };
            foreach (var logger in loggers)
            {
                logger.LogInfo("Having fun.");
                logger.LogError("OOp is sometimes confusing.");
            }
        }
    }
}




