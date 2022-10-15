using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.MediatorPattern
{
    internal interface IMediator
    {
        public void First();
        public void Second();
    }
    internal interface IColleague
    {
        public void Wrok();
        public void Complete();
    }
    internal class Mediator : IMediator
    {
        private readonly IColleague _firstColleague;
        private readonly IColleague _secondColleague;
        public Mediator(IColleague firstColleague, IColleague secondColleague)
        {
            _firstColleague = firstColleague;
            _secondColleague = secondColleague;
        }
        public void First()
        {
            Console.WriteLine("----------");
            _firstColleague.Wrok();
            _secondColleague.Wrok();
            _firstColleague.Complete();
            _secondColleague.Complete();
        }
        public void Second()
        {
            Console.WriteLine("----------");
            _secondColleague.Wrok();
            _firstColleague.Wrok();
            _firstColleague.Complete();
            _secondColleague.Complete();
        }
    }
    internal class FirstColleague : IColleague
    {
        public void Wrok() => Console.WriteLine("First.Wrok");
        public void Complete() => Console.WriteLine("First.Complete");
    }
    internal class SecondColleague : IColleague
    {
        public void Wrok() => Console.WriteLine("Second.Wrok");
        public void Complete() => Console.WriteLine("Second.Complete");
    }
}
