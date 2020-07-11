using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using Unity;

namespace Assignment_7
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            
            container.RegisterType<ICalculator, Calculator>();

            var service = container.Resolve<Calculator>();

            /*var provider = new ServiceCollection()
                           .AddSingleton<ICalculator, Calculator>()
                           .BuildServiceProvider();

            var service = provider.GetService<ICalculator>();*/

            var menuRecall = true;

            while (menuRecall)
            {
                CalculatorDisplayUtility.Menu(out menuRecall, service);
            }
        }
    }
}
