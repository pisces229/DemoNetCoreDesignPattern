using System;

namespace DemoNetCoreDesignPattern.DecoratorPattern
{
    internal interface IDecorator
    {
        public int Cost();
        public string Describe();
    }
    internal class Product : IDecorator
    {
        public int Cost() => 100;
        public string Describe() => "[Product]";
    }
    internal abstract class Decorator : IDecorator
    {
        protected readonly IDecorator _decorator;
        public Decorator(IDecorator decorator)
        {
            _decorator = decorator;
        }
        public abstract int Cost();
        public abstract string Describe();
    }
    internal class FirstDecorator : Decorator
    {
        public FirstDecorator(IDecorator decorator) : base(decorator)
        {
        }
        public override int Cost() => _decorator.Cost() + 1;
        public override string Describe() => $"{_decorator.Describe()}[First]";
    }
    internal class SecondDecorator : Decorator
    {
        public SecondDecorator(IDecorator decorator) : base(decorator)
        {
        }
        public override int Cost() => _decorator.Cost() + 10;
        public override string Describe() => $"{_decorator.Describe()}[Second]";
    }











    //internal abstract class Decorator
    //{
    //    protected Decorator? _decorator;
    //    public Decorator(Decorator? decorator)
    //    {
    //        _decorator = decorator;
    //    }
    //    public abstract string Describe();
    //}
    //internal class DefaultDecorator : Decorator
    //{
    //    public DefaultDecorator() : base(null) {}
    //    public override string Describe() => "[Default]";
    //}
    //internal class FirstDecorator : Decorator
    //{
    //    public FirstDecorator(Decorator? decorator) : base(decorator) {}
    //    public override string Describe() => $"{_decorator!.Describe()}[First]";
    //}
    //internal class SecondDecorator : Decorator
    //{
    //    public SecondDecorator(Decorator? decorator) : base(decorator) {}
    //    public override string Describe() => $"{_decorator!.Describe()}[Second]";
    //}
}
