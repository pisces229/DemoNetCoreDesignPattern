using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.IteratorPattern
{
    public class App
    {
        public static void Run()
        {
            var company = new Company();
            var iterator = company.CreateIterator();
            while (!iterator.IsDone())
            {
                var employee = iterator.Next();
                Console.WriteLine($"[{employee.Name()}][{employee.Title()}]");
            }
        }
    }
}
