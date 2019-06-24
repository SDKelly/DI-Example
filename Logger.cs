using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators
{
    public class Logger : ILogger
    {
        public Logger() { }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
