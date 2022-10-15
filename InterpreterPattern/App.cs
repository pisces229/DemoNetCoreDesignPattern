using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.InterpreterPattern
{
    public class App
    {
        public static void Run()
        {
            var firstInterpreter = new FirstInterpreter();
            var secondInterpreter = new SecondInterpreter();
            firstInterpreter.Interpret(new Context("first"));
            secondInterpreter.Interpret(new Context("SECOND"));
        }
    }
}
