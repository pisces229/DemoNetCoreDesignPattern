using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.DecoratorPattern
{
    internal abstract class Item
    {
        protected Item? _item;
        public Item(Item? item)
        {
            this._item = item;
        }
        public abstract string Description();
        public abstract int Cost();
    }
    internal class Order : Item
    {
        public Order() : base(null)
        { 
        }
        public override string Description() => "";
        public override int Cost() => 0;
    }
    internal class Salad : Item
    {
        public Salad(Item item) : base(item)
        {
        }
        public override string Description() => this._item!.Description() + "[Salad]";
        public override int Cost() => this._item!.Cost() + 30;
    }
    internal class Soup : Item
    {
        public Soup(Item item) : base(item)
        {
        }
        public override string Description() => this._item!.Description() + "[Soup]";
        public override int Cost() => this._item!.Cost() + 500;
    }
    internal class MainMeal : Item
    {
        public MainMeal(Item item) : base(item)
        {
        }
        public override string Description() => this._item!.Description() + "[MainMeal]";
        public override int Cost() => this._item!.Cost() + 1000;
    }
    internal class Drink : Item
    {
        public Drink(Item item) : base(item)
        {
        }
        public override string Description() => this._item!.Description() + "[Drink]";
        public override int Cost() => this._item!.Cost() + 9;
    }
}
