using System;

namespace DemoNetCoreDesignPattern.AbstractFactoryPattern
{
    internal class Store
    {
        public Product CreateFirstProduct() => new FirstProduct();
        public Product CreateSecondProduct() => new SecondProduct();
    }
    internal abstract class Product
    {
        protected readonly string _productName;
        public Product(string productName)
        {
            _productName = productName;
        }
        public abstract Service CreateFirstService();
        public abstract Service CreateSecondService();
    }
    internal class FirstProduct : Product
    {
        private const string NAME = "FirstProduct";
        public FirstProduct() : base(NAME) { }
        public override Service CreateFirstService() => new FirstService(NAME);
        public override Service CreateSecondService() => new SecondService(NAME);
    }
    internal class SecondProduct : Product
    {
        private const string NAME = "SecondProduct";
        public SecondProduct() : base("SecondProduct") { }
        public override Service CreateFirstService() => new FirstService(NAME);
        public override Service CreateSecondService() => new SecondService(NAME);
    }
    internal abstract class Service
    {
        protected readonly string _productName;
        protected readonly string _serviceName;
        public Service(string productName, string serviceName)
        {
            _productName = productName;
            _serviceName = serviceName;
        }
        public void Describe() => Console.WriteLine($"[{_productName}][{_serviceName}]");
    }
    internal class FirstService : Service
    {
        private const string NAME = "FirstService";
        public FirstService(string productName) : base(productName, NAME) { }
    }
    internal class SecondService : Service
    {
        private const string NAME = "SecondService";
        public SecondService(string productName) : base(productName, NAME) { }
    }
}
