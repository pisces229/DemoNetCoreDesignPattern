using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.BridgePattern
{
    internal class Class
    {
    }
    internal interface Person
    {
        public void Name();
        public void Email();
        public void Address();
    }
    internal class FirstPerson : Person
    {
        public void Name() => Console.WriteLine("FirstName");
        public void Email() => Console.WriteLine("FirstEmail");
        public void Address() => Console.WriteLine("FirstAddress");
    }
    internal class SecondPerson : Person
    {
        public void Name() => Console.WriteLine("SecondName");
        public void Email() => Console.WriteLine("SecondEmail");
        public void Address() => Console.WriteLine("SecondAddress");
    }
    internal abstract class View
    {
        protected readonly Person _person;
        public View(Person person)
        {
            _person = person;
        }
        public abstract void Describe();
    }
    internal class FewView : View
    {
        public FewView(Person person) : base(person) { }
        public override void Describe()
        {
            Console.WriteLine("FewView.Describe");
            _person.Name();
            _person.Email();
        }
    }
    internal class FullView : View
    {
        public FullView(Person person) : base(person) { }
        public override void Describe()
        {
            Console.WriteLine("FullView.Describe");
            _person.Name();
            _person.Email();
            _person.Address();
        }
    }
}
