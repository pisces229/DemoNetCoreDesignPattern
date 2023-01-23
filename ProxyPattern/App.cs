using System;

namespace DemoNetCoreDesignPattern.ProxyPattern
{
    public class App
    {
        public static void Run()
        {
            var user = new User();
            user.DoSomething();
            var agent = new Agent(user);
            agent.DoSomething();
        }
    }
}
