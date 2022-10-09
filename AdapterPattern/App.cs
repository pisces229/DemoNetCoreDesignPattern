using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.AdapterPattern
{
    public class App
    {
        public static void Run()
        {
            var blackMan = new BlackMan("First");
            blackMan.HelloEnglish();
            blackMan.IntroduceEnglish();
            var taiwanMan = new TaiwanMan(new BlackmanTranslator(blackMan.GetName()));
            taiwanMan.Hello();
            taiwanMan.Introduce();
        }
    }
}
