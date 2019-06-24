using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<ILogger, Logger>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var loggerService = serviceProvider.GetService<ILogger>();

            SimpleCalculator simpleCalculator = new SimpleCalculator(loggerService);

            int value1 = 10;

            int value2 = 20;

            int result = simpleCalculator.Add(value1, value2);

            Console.WriteLine("The result is: " + result);
        }
    }
}
