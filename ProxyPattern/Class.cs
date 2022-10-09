using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this._user = user;
        }
        public void DoSomething()
        {
            Console.WriteLine("User.DoSomething.Before");
            _user.DoSomething();
            Console.WriteLine("User.DoSomething.After");
        }
    }
}
