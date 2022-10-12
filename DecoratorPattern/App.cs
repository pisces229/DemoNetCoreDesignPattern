using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.DecoratorPattern
{
    public class App
    {
        public static void Run()
        {
            Decorator decorator = new DefaultDecorator();
            decorator = new FirstDecorator(decorator);
            decorator = new SecondDecorator(decorator);
            decorator = new FirstDecorator(decorator);
            Console.WriteLine(decorator.Describe());
        }
    }
}
