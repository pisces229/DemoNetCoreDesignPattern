using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.TemplateMethodPattern
{
    internal abstract class BossMethod
    {
        public abstract string UIDesign();
        public abstract string SystemAnalysis();
        public abstract string SystemDesign();
        public abstract string Programming();
        public abstract string Test();
        public void Complete()
        {
            Console.WriteLine($"[{UIDesign()}][{SystemAnalysis()}][{SystemDesign()}][{Programming()}][{Test()}]");
        }
    }
    internal class SoftwareManager : BossMethod 
    {
        public override string UIDesign() => "UIDesign";
        public override string SystemAnalysis() => "SystemAnalysis";
        public override string SystemDesign() => "SystemDesign";
        public override string Programming() => "Programming";
        public override string Test() => "Test";
    }
}