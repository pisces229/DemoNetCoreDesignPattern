using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FactoryMethodPattern
{
    internal interface IProduct
    {
        public void Describe();
    }
    internal class FirstProduct : IProduct
    {
        public void Describe() => Console.WriteLine("FirstProduct");
    }
    internal class SecondProduct : IProduct
    {
        public void Describe() => Console.WriteLine("SecondProduct");
    }
    internal interface IProductFactory
    {
        public IProduct? CreateProduct(Product product);
    }
    internal class ProductFactory : IProductFactory
    {
        public IProduct? CreateProduct(Product product)
        {
            switch (product)
            {
                case Product.First:
                    return new FirstProduct();
                case Product.Second:
                    return new SecondProduct();
                default:
                    return null;
            }
        }
    }
    internal enum Product
    { 
        First,
        Second,
    }
}