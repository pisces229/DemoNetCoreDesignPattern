using System;

namespace DemoNetCoreDesignPattern.SingletonPattern
{
    public class App
    {
        public static void Run()
        {
            for (var i = 0; i < 100; i++)
            {
                Task.Run(() => Singleton.GetInstance().Describe());
            }
            Thread.Sleep(1000);
            Singleton.GetInstance().Describe();
        }
    }
}
