using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.AdapterPattern
{
    internal interface ITarget
    {
        public void Describe();
    }
    internal class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Describe() => _adaptee.Describe();
    }
    internal class Adaptee
    {
        public void Describe() => Console.WriteLine("Adaptee.Describe");
    }
}
