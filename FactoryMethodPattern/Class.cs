using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FactoryMethodPattern
{
    internal interface IProduct
    {
        void Describe();
    }
    internal class FrenchFries : IProduct
    {
        private readonly string _state = "Default";
        public FrenchFries()
        {
        }
        public FrenchFries(string state)
        {
            this._state = state;
        }
        public void Describe()
        {
            Console.WriteLine($"This is [{this._state}]");
        }
    }
    internal interface IFactory
    {
        IProduct GetProduct();
    }
    internal class FrenchFriesFactory : IFactory
    {
        public FrenchFriesFactory()
        {
        }
        public IProduct GetProduct() => new FrenchFries();
        public IProduct GetProduct(string state) => new FrenchFries(state);
    }
}