using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.StatePattern
{
    internal abstract class BaseState
    {
        public abstract void Push();
        public abstract void Pop();
    }
    internal class EmptyState : BaseState
    {
        private readonly Box _box;
        public EmptyState(Box box)
        { 
            _box = box;
        }
        public override void Push()
        {
            Console.WriteLine("EmptyState.Push");
            _box.PushCount();
            _box.Change(State.HasState);
        }
        public override void Pop()
        {
            Console.WriteLine("EmptyState.Pop");
        }
    }
    internal class HasState : BaseState
    {
        private readonly Box _box;
        public HasState(Box box)
        {
            _box = box;
        }
        public override void Push()
        {
            Console.WriteLine("HasState.Push");
            _box.PushCount();
            if (_box.IsFull())
            {
                _box.Change(State.FullState);
            }
        }
        public override void Pop()
        {
            Console.WriteLine("HasState.Pop");
            _box.PopCount();
            if (_box.IsEmpty())
            {
                _box.Change(State.Empty);
            }
        }
    }
    internal class FullState : BaseState
    {
        private readonly Box _box;
        public FullState(Box box)
        {
            _box = box;
        }
        public override void Push()
        {
            Console.WriteLine("FullState.Push");
        }
        public override void Pop()
        {
            Console.WriteLine("FullState.Pop");
            _box.PopCount();
            _box.Change(State.HasState);
        }
    }
    internal class Box
    {
        private int _count = 0;
        private const int MIN_COUNT = 0;
        private const int MAX_COUNT = 3;
        private BaseState _currentState;
        private readonly EmptyState _emptyState;
        private readonly HasState _hasState;
        private readonly FullState _fullState;
        public Box()
        {
            _emptyState = new EmptyState(this);
            _hasState = new HasState(this);
            _fullState = new FullState(this);
            _currentState = _emptyState;
        }
        public void PushCount() => _count++;
        public void PopCount() => _count--;
        public bool IsEmpty() => _count == MIN_COUNT;
        public bool IsFull() => _count == MAX_COUNT;
        public void Change(State state)
        {
            switch (state)
            {
                case State.Empty:
                    _currentState = _emptyState;
                    break;
                case State.HasState:
                    _currentState = _hasState;
                    break;
                case State.FullState:
                    _currentState = _fullState;
                    break;
            }
        }
        public void Push() => _currentState.Push();
        public void Pop() => _currentState.Pop();
        public void Check() => Console.WriteLine(_currentState.ToString());
    }
    internal enum State
    {
        Empty,
        HasState,
        FullState,
    }
}
