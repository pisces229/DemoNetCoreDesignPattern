using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern
{
    internal class App
    {
        public static void Run(Pattern pattern)
        {
            switch (pattern)
            {
                case Pattern.FactoryMethodPattern:
                    FactoryMethodPattern.App.Run();
                    break;
                case Pattern.StrategyPattern:
                    StrategyPattern.App.Run();
                    break;
                case Pattern.SingletonPattern:
                    SingletonPattern.App.Run();
                    break;
                case Pattern.DecoratorPattern:
                    DecoratorPattern.App.Run();
                    break;
                case Pattern.ObserverPattern:
                    ObserverPattern.App.Run();
                    break;
                case Pattern.CommandPattern:
                    CommandPattern.App.Run();
                    break;
                case Pattern.BuilderPattern:
                    BuilderPattern.App.Run();
                    break;
                case Pattern.TemplateMethodPattern:
                    TemplateMethodPattern.App.Run();
                    break;
                case Pattern.AdapterPattern:
                    AdapterPattern.App.Run();
                    break;
                case Pattern.ProxyPattern:
                    ProxyPattern.App.Run();
                    break;
                case Pattern.PrototypePattern:
                    PrototypePattern.App.Run();
                    break;
                case Pattern.FacadePattern:
                    FacadePattern.App.Run();
                    break;
                case Pattern.StatePattern:
                    StatePattern.App.Run();
                    break;
                case Pattern.MemotoPattern:
                    MemotoPattern.App.Run();
                    break;
                case Pattern.FlyweightPattern:
                    FlyweightPattern.App.Run();
                    break;
                case Pattern.CompositePattern:
                    CompositePattern.App.Run();
                    break;
                case Pattern.IteratorPattern:
                    IteratorPattern.App.Run();
                    break;
                case Pattern.BridgePattern:
                    BridgePattern.App.Run();
                    break;
                case Pattern.ChainOfResponsibilityPattern:
                    ChainOfResponsibilityPattern.App.Run();
                    break;
                case Pattern.MediatorPattern:
                    MediatorPattern.App.Run();
                    break;
                case Pattern.InterpreterPattern:
                    InterpreterPattern.App.Run();
                    break;
                case Pattern.VisitorPattern:
                    VisitorPattern.App.Run();
                    break;
                case Pattern.AbstractFactoryPattern:
                    AbstractFactoryPattern.App.Run();
                    break;
            }
        }
    }
    internal enum Pattern
    {
        FactoryMethodPattern,
        StrategyPattern,
        SingletonPattern,
        DecoratorPattern,
        ObserverPattern,
        CommandPattern,
        BuilderPattern,
        TemplateMethodPattern,
        AdapterPattern,
        ProxyPattern,
        PrototypePattern,
        FacadePattern,
        StatePattern,
        MemotoPattern,
        FlyweightPattern,
        CompositePattern,
        IteratorPattern,
        BridgePattern,
        ChainOfResponsibilityPattern,
        MediatorPattern,
        InterpreterPattern,
        VisitorPattern,
        AbstractFactoryPattern,
    }
}
