using System;

namespace DemoNetCoreDesignPattern.ObserverPattern
{
    internal interface IObserverable
    {
        public string GetName();
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void NotifyObservers(string message);
    }
    internal interface IObserver
    {
        public void Receive(string message);
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
        public void NotifyObservers(string message) 
            => _observers.ForEach(observer => observer.Receive(message));
    }
    internal class Student : IObserver
    {
        private readonly int _id;
        private IObserverable _observerable;
        public Student(IObserverable observerable)
        {
            _id = GetHashCode();
            observerable.Add(this);
            _observerable = observerable;
        }
        public void Receive(string message) 
            => Console.WriteLine($"[{_observerable.GetName()}] Send [{message}] To [{_id}]");
    }
}
