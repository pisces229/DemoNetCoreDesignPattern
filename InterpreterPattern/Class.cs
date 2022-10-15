using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.InterpreterPattern
{
    internal class Class
    {
    }
    internal class Context
    {
        private readonly string _text;
        public Context(string text)
        { 
            _text= text;
        }
        public string Text() => _text;
    }
    internal abstract class Interpreter
    {
        public abstract void Interpret(Context context);
    }
    internal class FirstInterpreter
    {
        public void Interpret(Context context)
            => Console.WriteLine($"FirstInterpreter[{context.Text().ToUpper()}]");
    }
    internal class SecondInterpreter
    {
        public void Interpret(Context context)
            => Console.WriteLine($"SecondInterpreter[{context.Text().ToLower()}]");
    }
}
