using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.CompositePattern
{
    public class App
    {
        public static void Run()
        {
            var component = new Component("Component");
            var composite1 = new Composite("Component-Composite[1]");
            composite1.Add(new Composite("Component-Composite[1]-Composite[1]"));
            composite1.Add(new Leaf("Component-Composite[1]-Leaf[1]"));
            component.Add(composite1);
            var leaf1 = new Leaf("Component-Leaf[2]");
            leaf1.Add(new Composite("Component-Leaf[1]-Composite[1]"));
            leaf1.Add(new Leaf("Component-Leaf[1]-Leaf[1]"));
            component.Add(leaf1);
            component.Describe();
        }
    }
}
