using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.SingletonPattern
{
    public class App
    {
        public static void Run()
        {
            for (var i = 0; i < 100; i++)
            {
                Task.Run(() => Singleton.GetInstance().Display());
            }
            Thread.Sleep(1000);
            Singleton.GetInstance().Display();
        }
    }
}
