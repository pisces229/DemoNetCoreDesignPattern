using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoNetCoreDesignPattern.ChainOfResponsibilityPattern
{
    internal class Thing
    {
        private readonly string _name;
        public Thing(string name)
        {
            _name = name;
        }
        public string Name() => _name;
    }
    internal abstract class Handler
    {
        protected readonly Handler? _handler;
        public Handler(Handler? handler)
        {
            _handler = handler;
        }
        public abstract void Next(Thing thing);
    }
    internal class FirstHandler : Handler
    {
        public FirstHandler(Handler? handler) : base(handler) { }
        public override void Next(Thing thing)
        {
            if ("First" == thing.Name())
            {
                Console.WriteLine($"FirstHandler");
            }
            else
            {
                _handler?.Next(thing);
            }
        }
    }
    internal class SecondHandler : Handler
    {
        public SecondHandler(Handler? handler) : base(handler) { }
        public override void Next(Thing thing)
        {
            if ("Second" == thing.Name())
            {
                Console.WriteLine($"SecondHandler");
            }
            else if (_handler != null)
            {
                _handler.Next(thing);
            }
        }
    }
    internal class ThirdHandler : Handler
    {
        public ThirdHandler(Handler? handler) : base(handler) { }
        public override void Next(Thing thing)
        {
            if ("Third" == thing.Name())
            {
                Console.WriteLine($"ThirdHandler");
            }
            else
            {
                _handler?.Next(thing);
            }
        }
    }
}
