using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.VisitorPattern
{
    public class App
    {
        public static void Run()
        {
            var items = new List<IItem>()
            {
                new FirstItem(),
                new SecondItem(),
                new FirstItem(),
                new SecondItem(),
                new SecondItem(),
            };
            var firstVisitor = new FirstVisitor();
            var secondVisitor = new SecondVisitor();
            firstVisitor.Visit(items);
            secondVisitor.Visit(items);
        }
    }
}
