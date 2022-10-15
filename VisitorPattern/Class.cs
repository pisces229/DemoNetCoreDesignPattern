using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.VisitorPattern
{
    internal interface IItem
    {
        public string Name();
        public void Describe();
    }
    internal class FirstItem : IItem
    {
        public string Name() => $"First";
        public void Describe() => Console.WriteLine("First");
    }
    internal class SecondItem : IItem
    {
        public string Name() => "Second";
        public void Describe() => Console.WriteLine("Second");
    }
    internal interface Visitor
    {
        public void Visit(List<IItem> items);
    }
    internal class FirstVisitor : Visitor
    {
        public void Visit(List<IItem> items)
        {
            foreach (var item in items.Where(p => p.Name() == "First"))
            {
                item.Describe();
            }
        }
    }
    internal class SecondVisitor : Visitor
    {
        public void Visit(List<IItem> items)
        {
            foreach (var item in items.Where(p => p.Name() == "Second"))
            {
                item.Describe();
            }
        }
    }
}
