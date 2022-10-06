using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.StrategyPattern
{
    internal class Calculator
    {
        private IStrategy? _strategy;
        public int Caculate(int a, int b) => this._strategy!.Caculate(a, b);
        public void SetStrategy(DoType doType)
        {
            switch (doType)
            {
                case DoType.ADD:
                    this._strategy = new AddStrategy();
                    break;
                case DoType.MINUS:
                    this._strategy = new MinusStrategy();
                    break;
                case DoType.DIVIDE:
                    this._strategy = new DivideStrategy();
                    break;
                case DoType.MULTYPLY:
                    this._strategy = new MultyplyStrategy();
                    break;
            }
        }
        public enum DoType
        {
            ADD, 
            MINUS, 
            DIVIDE, 
            MULTYPLY
        }
    }
    internal interface IStrategy
    {
        public int Caculate(int a, int b);
    }
    internal class AddStrategy : IStrategy
    {
        public int Caculate(int a, int b) => a + b;
    }
    internal class MinusStrategy : IStrategy
    {
        public int Caculate(int a, int b) => a - b;
    }
    internal class MultyplyStrategy : IStrategy
    {
        public int Caculate(int a, int b) => a * b;
    }
    internal class DivideStrategy : IStrategy
    {
        public int Caculate(int a, int b) => a / b;
    }
}
