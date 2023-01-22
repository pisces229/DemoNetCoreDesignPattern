using System;

namespace DemoNetCoreDesignPattern.DecoratorPattern
{
    public class App
    {
        public static void Run()
        {
            IDecorator product = new Product();
            product = new FirstDecorator(product);
            product = new SecondDecorator(product);
            product = new SecondDecorator(product);
            product = new FirstDecorator(product);
            Console.WriteLine(product.Cost());
            Console.WriteLine(product.Describe());
        }
    }
}
