using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.MediatorPattern
{
    public class App
    {
        public static void Run()
        {
            var firstColleague = new FirstColleague();
            var secondColleague = new SecondColleague();
            var mediator = new Mediator(firstColleague, secondColleague);
            mediator.First();
            mediator.Second();
        }
    }
}
