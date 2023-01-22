using System;
using System.Runtime.CompilerServices;

namespace DemoNetCoreDesignPattern.SingletonPattern
{
    internal class Singleton
    {
        private int _count;
        private static Singleton? _instance;
        public Singleton()
        {
            _count = 0;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
        }
        public void Describe() => Console.WriteLine($"[{_count++}]");
    }
}
