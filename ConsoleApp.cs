using System;

namespace Calculators
{
    public class ConsoleApp
    {
        private readonly ILogger _logger;
        public ConsoleApp(ILogger logger)
        {
            _logger = logger;
        }

    }
}
