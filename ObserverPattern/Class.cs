using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.ObserverPattern
{
    internal interface IObserverable
    {
        public string GetName();
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void NotifyObservers();
    }
    internal interface IObserver
    {
        public void Receive();
    }
    internal class Podcast : IObserverable
    {
        private readonly string _name;
        private readonly List<IObserver> _observers;
        public Podcast(string name)
        {
            _name = name;
            _observers = new List<IObserver>();
        }
        public string GetName() => _name;
        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers() => _observers.ForEach(observer => observer.Receive());
    }
    internal class Student : IObserver
    {
        private readonly string _name;
        private IObserverable? _observerable;
        public Student(string name)
        {
            _name = name;
        }
        public void Subscribe(IObserverable observerable)
        {
            observerable.Add(this);
           _observerable = observerable;
        }
        public void Receive() => Console.WriteLine($"[{_name}][{_observerable!.GetName()}]");
    }
}
