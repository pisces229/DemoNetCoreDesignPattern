using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.MemotoPattern
{
    public class App
    {
        public static void Run()
        {
            var memotoState = new MemotoState();
            var currentState = new State(10);
            currentState.Minus();
            currentState.Describe();
            memotoState.Save(currentState);
            currentState.Plus();
            currentState.Plus();
            currentState.Describe();
            currentState = memotoState.Restore();
            currentState.Describe();
        }
    }
}
