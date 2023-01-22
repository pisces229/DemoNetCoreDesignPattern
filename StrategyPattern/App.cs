using System;

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
