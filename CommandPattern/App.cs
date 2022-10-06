using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.CommandPattern
{
    public class App
    {
        public static void Run()
        {
            var light = new Light();
            var turnOn = new TurnOn(light);
            var brighter = new Brighter(light);
            var darker = new Darker(light);
            var invoker = new Invoker();
            invoker.Add(turnOn);
            invoker.Add(brighter);
            invoker.Add(brighter);
            invoker.Add(brighter);
            invoker.Add(darker);
            invoker.Execute();
        }
    }
}
