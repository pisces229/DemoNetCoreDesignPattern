using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.CommandPattern
{
    internal class Light
    {
        public void TurnOn() => Console.WriteLine("Turn On");
        public void TurnOff() =>Console.WriteLine("Turn Off");
        public void Brighter() => Console.WriteLine("Brighter");
        public void Darker() => Console.WriteLine("Darker");
    }
    internal abstract class Command
    {
        protected readonly Light _light;
        public Command(Light light)
        {
            this._light = light;
        }
        public abstract void Execute();
    }
    internal class TurnOn : Command
    {
        public TurnOn(Light light) : base(light) { }
        public override void Execute() => this._light.TurnOn();
    }
    internal class TurnOff : Command
    {
        public TurnOff(Light light) : base(light) { }
        public override void Execute() => this._light.TurnOff();
    }
    internal class Brighter : Command
    {
        public Brighter(Light light) : base(light) { }
        public override void Execute() => this._light.Brighter();
    }
    internal class Darker : Command
    {
        public Darker(Light light) : base(light) { }
        public override void Execute() => this._light.Darker();
    }
    internal class Invoker
    {
        private readonly List<Command> _commands;
        public Invoker()
        {
            _commands = new List<Command>();
        }
        public void Add(Command command) => _commands.Add(command);
        public void Execute() => _commands.ForEach(command => command.Execute());
    }
}
