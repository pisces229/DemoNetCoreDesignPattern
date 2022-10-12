using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.StrategyPattern
{
    public class App
    {
        public static void Run()
        {
            var strategy = new Strategy();
            strategy.SetStrategy(StrategyType.First);
            strategy.Describe();
            strategy.SetStrategy(StrategyType.Second);
            strategy.Describe();
        }
    }
}
