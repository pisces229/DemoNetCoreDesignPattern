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
        public abstract void HandleRequest(Thing thing);
    }
    internal class EntryHandler : Handler
    {
        public EntryHandler() : base(new FirstHandler()) { }
        public override void HandleRequest(Thing thing)
        {
            if (_handler != null)
            {
                _handler.HandleRequest(thing);
            }
            else
            {
                Console.WriteLine($"EntryHandler.Finally.[{thing.Name()}]");
            }
        }
    }
    internal class FirstHandler : Handler
    {
        public FirstHandler() : base(new SecondHandler()) { }
        public override void HandleRequest(Thing thing)
        {
            if ("First" == thing.Name())
            {
                Console.WriteLine($"FirstHandler.Cache.[{thing.Name()}]");
            }
            else if (_handler != null)
            {
                _handler.HandleRequest(thing);
            }
            else
            {
                Console.WriteLine($"FirstHandler.Finally.[{thing.Name()}]");
            }
        }
    }
    internal class SecondHandler : Handler
    {
        public SecondHandler() : base(null) { }
        public override void HandleRequest(Thing thing)
        {
            if ("Second" == thing.Name())
            {
                Console.WriteLine($"SecondHandler.Cache.[{thing.Name()}]");
            }
            else if (_handler != null)
            {
                _handler.HandleRequest(thing);
            }
            else
            {
                Console.WriteLine($"SecondHandler.Finally.[{thing.Name()}]");
            }
        }
    }
}
