using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.TemplateMethodPattern
{
    public class App
    {
        public static void Run()
        {
            var softwareManager = new SoftwareManager();
            softwareManager.Complete();
        }
    }
}
