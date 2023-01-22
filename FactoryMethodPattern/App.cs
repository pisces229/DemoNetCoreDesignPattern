using System;

namespace DemoNetCoreDesignPattern.FactoryMethodPattern
{
    public class App
    {
        public static void Run()
        {
            var productFactory = new ProductFactory();
            productFactory.CreateProduct(Product.First)!.Describe();
            productFactory.CreateProduct(Product.Second)!.Describe();
        }
    }
}
