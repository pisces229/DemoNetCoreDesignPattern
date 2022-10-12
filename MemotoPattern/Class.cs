using DemoNetCoreDesignPattern.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.MemotoPattern
{
    internal class State
    {
        private int count = 0;
        public State(int count)
        {
            this.count = count;
        }
        public int Count() => count;
        public void Plus() => count++;
        public void Minus() => count--;
        public void Describe() => Console.WriteLine(count);
    }
    internal class MemotoState
    {
        private State? _state;
        public void Save(State state)
        {
            _state = new State(state.Count());
        }
        public State Restore() => new(_state!.Count());
    }
}
