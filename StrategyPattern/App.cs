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
            var calculator = new Calculator();
            calculator.SetStrategy(Calculator.DoType.ADD);
            Console.WriteLine($"ADD [{calculator.Caculate(8, 2)}]");
            calculator.SetStrategy(Calculator.DoType.MINUS);
            Console.WriteLine($"MINUS [{calculator.Caculate(8, 2)}]");
            calculator.SetStrategy(Calculator.DoType.MULTYPLY);
            Console.WriteLine($"MULTYPLY [{calculator.Caculate(8, 2)}]");
            calculator.SetStrategy(Calculator.DoType.DIVIDE);
            Console.WriteLine($"DIVIDE [{calculator.Caculate(8, 2)}]");
        }
    }
}
