using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.BridgePattern
{
    public class App
    {
        public static void Run()
        {
            var firstPerson = new FirstPerson();
            var secondPerson = new SecondPerson();
            new FewView(firstPerson).Describe();
            new FullView(secondPerson).Describe();
            new FewView(firstPerson).Describe();
            new FullView(secondPerson).Describe();
        }
    }
}
