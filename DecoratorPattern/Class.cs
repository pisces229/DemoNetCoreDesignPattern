using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.DecoratorPattern
{
    internal abstract class Decorator
    {
        protected Decorator? _decorator;
        public Decorator(Decorator? decorator)
        {
            _decorator = decorator;
        }
        public abstract string Describe();
    }
    internal class DefaultDecorator : Decorator
    {
        public DefaultDecorator() : base(null) {}
        public override string Describe() => "[Default]";
    }
    internal class FirstDecorator : Decorator
    {
        public FirstDecorator(Decorator? decorator) : base(decorator) {}
        public override string Describe() => $"{_decorator!.Describe()}[First]";
    }
    internal class SecondDecorator : Decorator
    {
        public SecondDecorator(Decorator? decorator) : base(decorator) {}
        public override string Describe() => $"{_decorator!.Describe()}[Second]";
    }
}
