using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.PrototypePattern
{
    internal class Person
    {
        public string? Name { get; set; }
        public DateOnly? Birthday { get; set; }
        public void Information()
        {
            Console.WriteLine($"[{this.GetHashCode()}][{this.Name}][{this.Birthday}]");
        }
        public Person Clone()
        { 
            var person = new Person();
            person.Name = this.Name;
            person.Birthday = this.Birthday;
            return person;   
        }
    }
}
