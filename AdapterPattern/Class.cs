using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.AdapterPattern
{
    internal class BlackMan
    {
        private readonly string _name;
        public BlackMan(string name)
        {
            this._name = name;
        }
        public string GetName() => this._name;
        public void HelloEnglish()
            => Console.WriteLine($"{this.GetName()}:BlackMan.HelloEnglish");
        public void IntroduceEnglish()
            => Console.WriteLine($"{this.GetName()}:BlackMan.IntroduceEnglish");
    }
    internal abstract class People
    {
        private readonly string _name;
        public People(string name)
        {
            this._name = name;
        }
        public string GetName() => this._name;
        public abstract void Hello();
        public abstract void Introduce();
    }
    internal class BlackmanTranslator : People
    {
        public BlackmanTranslator(string name) : base(name) { }
        public override void Hello()
            => Console.WriteLine($"{this.GetName()}:BlackmanTranslator.Hello");
        public override void Introduce()
            => Console.WriteLine($"{this.GetName()}:BlackmanTranslator.Introduce");
    }
    internal class TaiwanMan
    {
        private readonly People _people;
        public TaiwanMan(People people)
        {
            this._people = people;
        }
        public void Hello() => this._people.Hello();
        public void Introduce() => this._people.Introduce();
    }
}
