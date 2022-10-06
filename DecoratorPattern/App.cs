using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.DecoratorPattern
{
    public class App
    {
        public static void Run()
        {
            Item order = new Order();
            order = new Salad(order);
            order = new Soup(order);
            order = new MainMeal(order);
            order = new Drink(order);
            Console.WriteLine(order.Description());
            Console.WriteLine(order.Cost());
        }
    }
}
