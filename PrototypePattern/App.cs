using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.PrototypePattern
{
    public class App
    {
        public static void Run()
        { 
            var person = new Person();
            person.Name = "Person";
            person.Birthday = DateOnly.FromDateTime(DateTime.Now);
            person.Information();
            person.Clone().Information();
        }
    }
}
