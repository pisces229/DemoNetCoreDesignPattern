using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FlyweightPattern
{
    public class App
    {
        public static void Run()
        {
            var childManager = new ChildManager();
            childManager.AddChild(10, "First");
            childManager.AddChild(20, "Second");
            childManager.AddChild(30, "Third");
            childManager.GetChild(1).Describe();
            childManager.GetChild(0).Describe();
            childManager.GetChild(2).Describe();
        }
    }
}
