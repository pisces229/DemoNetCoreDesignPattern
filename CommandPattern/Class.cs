using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.CommandPattern
{
    internal class All
    {
        public void First() => Console.WriteLine("First");
        public void Second() =>Console.WriteLine("Second");
        public void Third() => Console.WriteLine("Third");
    }
    internal abstract class Command
    {
        protected readonly All _all;
        public Command(All all)
        {
            _all = all;
        }
        public abstract void Describe();
    }
    internal class First : Command
    {
        public First(All all) : base(all) { }
        public override void Describe() => _all.First();
    }
    internal class Second : Command
    {
        public Second(All all) : base(all) { }
        public override void Describe() => _all.Second();
    }
    internal class Third : Command
    {
        public Third(All all) : base(all) { }
        public override void Describe() => _all.Third();
    }
    internal class Invoker
    {
        private Command? _command;
        public void Set(Command command) => _command = command;
        public void Describe() => _command!.Describe();
    }
    internal class Queuer
    {
        private readonly List<Command> _commands;
        public Queuer()
        {
            _commands = new List<Command>();
        }
        public void Add(params Command[] command) => _commands.AddRange(command);
        public void Describe() => _commands.ForEach(command => command.Describe());
    }
}
