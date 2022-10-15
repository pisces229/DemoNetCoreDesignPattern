using DemoNetCoreDesignPattern.ProxyPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.CompositePattern
{
    internal class Component
    {
        private readonly string _name;
        private readonly List<Component> components = new List<Component>();
        public Component(string name)
        {
            _name = name;
        }
        public virtual void Add(Component component) => components.Add(component);
        public virtual void Remove(Component component) => components.Remove(component);
        public void Describe()
        {
            Console.WriteLine(_name);
            components.ForEach(component => component.Describe());
        }
    }
    internal class Composite : Component
    {
        public Composite(string name): base(name) { }
    }
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void Add(Component component)
            => Console.WriteLine("Leaf can't add component");
        public override void Remove(Component component)
            => Console.WriteLine("Leaf cant remove component");
    }
}
