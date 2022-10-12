using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FacadePattern
{
    public class App
    {
        public static void Run()
        {
            var facade = new Facade();
            facade.MethodOneAndTwo();
            facade.MethodThree();
        }
    }
}
