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
            var entryHandler = new EntryHandler();
            entryHandler.HandleRequest(new Thing("First"));
            entryHandler.HandleRequest(new Thing("Second"));
            entryHandler.HandleRequest(new Thing("Third"));
        }
    }
}
