using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FacadePattern
{
    internal class FacadeOne
    {
        public void MethodOne() => Console.WriteLine("One");
    }
    internal class FacadeTwo
    {
        public void MethodTwo() => Console.WriteLine("Two");
    }
    internal class FacadeThree
    {
        public void MethodThree() => Console.WriteLine("Three");
    }
    internal class Facade
    {
        private readonly FacadeOne _one;
        private readonly FacadeTwo _two;
        private readonly FacadeThree _three;
        public Facade()
        {
            _one = new FacadeOne();
            _two = new FacadeTwo();
            _three = new FacadeThree();
        }
        public void MethodOneAndTwo()
        {
            _one.MethodOne();
            _two.MethodTwo();
        }
        public void MethodThree()
        {
            _three.MethodThree();
        }
    }
}
