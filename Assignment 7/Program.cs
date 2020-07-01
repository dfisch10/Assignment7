using System;
using System.Diagnostics.CodeAnalysis;
using DryIoc;
using ImTools;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment_7
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new ServiceCollection()
                           .AddSingleton<ICalculator, Calculator>()
                           .BuildServiceProvider();

            var service = provider.GetService<ICalculator>();

            var menuRecall = true;

            var displayMenu = new CalculatorDisplayUtility();

            while (menuRecall)
            {
                displayMenu.Menu(out menuRecall, service);
            }
        }
    }
}
