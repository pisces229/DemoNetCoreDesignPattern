using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.IteratorPattern
{
    internal class Employee
    {
        private readonly string _name;
        private readonly string _title;
        public Employee(string name, string title)
        {
            _name = name;
            _title = title;
        }
        public string Name() => _name;
        public string Title() => _title;
    }
    internal interface Iiterator
    {
        public Employee Next();
        public bool IsDone();
    }
    internal interface IAggregate
    {
        public Iiterator CreateIterator();
    }
    internal class Company : IAggregate
    {
        private readonly List<Employee> _employees = new();
        public Company()
        {
            _employees.Add(new Employee("0", "Root"));
            _employees.Add(new Employee("1", "First"));
            _employees.Add(new Employee("2", "Second"));
            _employees.Add(new Employee("3", "Third"));
        }
        public List<Employee> Employees() => _employees;
        public Iiterator CreateIterator() => new CompanyIterator(this);
    }
    internal class CompanyIterator : Iiterator
    {
        private readonly Company _company;
        private int _current = 0;
        public CompanyIterator(Company company)
        {
            _company = company;
        }
        public Employee Next() => _company.Employees().Skip(_current++).First();
        public bool IsDone() => _current >= _company.Employees().Count() ? true : false;
    }
}
