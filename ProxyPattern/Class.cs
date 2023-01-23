using System;

namespace DemoNetCoreDesignPattern.ProxyPattern
{
    internal interface IProxy
    {
        public void DoSomething();
    }
    internal class User : IProxy
    {
        public void DoSomething()
        {
            Console.WriteLine("User.DoSomething");
        }
    }
    internal class Agent : IProxy
    {
        private readonly IProxy _user;
        public Agent(IProxy user)
        { 
            _user = user;
        }
        public void DoSomething()
        {
            Console.WriteLine("Agent.DoSomething.Start");
            _user.DoSomething();
            Console.WriteLine("Agent.DoSomething.End");
        }
    }
}
