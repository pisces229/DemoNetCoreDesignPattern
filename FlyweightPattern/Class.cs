using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.FlyweightPattern
{
    internal class Child
    {
        private int? _id;
        private int? _age;
        private string? _name;
        public void SetId(int id) => _id = id;

        public void SetAge(int age) => _age = age;
        public void SetName(string name) => _name = name;
        public void Describe() => Console.WriteLine($"[{_id}][{_age}][{_name}]");
    }
    internal class ChildManager
    {
        private readonly List<int> _ages = new();
        private readonly List<string> _names = new();
        private readonly Child _child = new ();
        public void AddChild(int age, string name)
        {
            _ages.Add(age);
            _names.Add(name);
        }
        public Child GetChild(int id)
        {
            _child.SetId(id);
            _child.SetAge(_ages.Skip(id).First());
            _child.SetName(_names.Skip(id).First());
            return _child;
        }
    }
}
