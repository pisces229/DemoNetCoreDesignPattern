using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.StatePattern
{
    public class App
    {
        public static void Run()
        { 
            var box = new Box();
            box.Pop();
            box.Check();
            Console.WriteLine("----------");
            box.Push();
            box.Check();
            box.Push();
            box.Check();
            box.Push();
            box.Check();
            box.Push();
            box.Check();
            Console.WriteLine("----------");
            box.Pop();
            box.Check();
            box.Pop();
            box.Check();
            box.Pop();
            box.Check();
            box.Pop();
            box.Check();
        }
    }
}
