using System;

namespace DemoNetCoreDesignPattern.StrategyPattern
{
    internal class Strategy
    {
        private IStrategy? _strategy;
        public void Describe() => _strategy!.Describe();
        public void SetStrategy(StrategyType strategyType)
        {
            switch (strategyType)
            {
                case StrategyType.First:
                    _strategy = new FirstStrategy();
                    break;
                case StrategyType.Second:
                    _strategy = new SecondStrategy();
                    break;
            }
        }
    }
    internal enum StrategyType
    {
        First,
        Second,
    }
    internal interface IStrategy
    {
        public void Describe();
    }
    internal class FirstStrategy : IStrategy
    {
        public void Describe() => Console.WriteLine("First");
    }
    internal class SecondStrategy : IStrategy
    {
        public void Describe() => Console.WriteLine("Second");
    }
}
