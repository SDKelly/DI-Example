using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators
{
    public class SimpleCalculator
    {
        ILogger _logger;
        public SimpleCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Add(int value1, int value2)
        {
            _logger.Log("Adding " + value1 + " and " + value2);

            return (value1 + value2);
        }
    }
}
