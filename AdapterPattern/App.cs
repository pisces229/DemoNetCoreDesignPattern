using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.AdapterPattern
{
    public class App
    {
        public static void Run()
        {
            var adaptee = new Adaptee();
            adaptee.Describe();
            var adapter = new Adapter(adaptee);
            adapter.Describe();
        }
    }
}
