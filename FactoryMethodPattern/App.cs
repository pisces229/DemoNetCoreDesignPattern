using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FactoryMethodPattern
{
    public class App
    {
        public static void Run()
        {
            var friesFactory = new FrenchFriesFactory();
            var FriesFirst = friesFactory.GetProduct();
            var FriesSecond = friesFactory.GetProduct("Salt");
            FriesFirst.Describe();
            FriesSecond.Describe();
        }
    }
}
