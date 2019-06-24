using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calculators
{
    public class Logger2 : ILogger
    {
        public Logger2()
        {

        }

        public void Log(string Message)
        {
            FileStream logFile;

            if (!File.Exists("C:/SimpleCalculatorLogs/logger2.txt"))
            {
               logFile = File.Create("C:/SimpleCalculatorLogs/logger2.txt");
            }
            else
            {
                logFile = File.OpenWrite("C:/SimpleCalculatorLogs/logger2.txt");
            }

            var logWriter = new System.IO.StreamWriter(logFile);

            logWriter.WriteLine(Message);

            logWriter.Dispose();
        }
    }
}
