using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.ChainOfResponsibilityPattern
{
    public class App
    {
        public static void Run()
        {
            {
                var handler = new FirstHandler(
                    new SecondHandler(null));
                handler.Next(new Thing("First"));
            }
            {
                var handler = new FirstHandler(
                    new SecondHandler(
                    new ThirdHandler(null)));
                handler.Next(new Thing("Third"));
            }
        }
    }
}
