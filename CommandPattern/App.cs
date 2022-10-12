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
            var all = new All();
            var first = new First(all);
            var second = new Second(all);
            var third = new Third(all);
            var invoker = new Invoker();
            invoker.Set(first);
            invoker.Describe();
            Console.WriteLine("----------");
            invoker.Set(second);
            invoker.Describe();
            Console.WriteLine("----------");
            var queuer = new Queuer();
            queuer.Add(first, second,  third, second, first);
            queuer.Describe();
        }
    }
}
