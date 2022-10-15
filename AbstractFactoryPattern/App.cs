using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.AbstractFactoryPattern
{
    public class App
    {
        public static void Run()
        {
            var store = new Store();
            store.CreateFirstProduct().CreateFirstService().Describe();
            store.CreateFirstProduct().CreateSecondService().Describe();
            store.CreateSecondProduct().CreateFirstService().Describe();
            store.CreateSecondProduct().CreateSecondService().Describe();
        }
    }
}
