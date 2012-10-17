using System.Collections.Generic;

namespace BDDSample
{
    public class Calc
    {
        private readonly Stack<int> _acumulator = new Stack<int>();

        public void EnterValue(int value)
        {
            _acumulator.Push(value);
        }

        public void Add()
        {
            var op1 = _acumulator.Pop();
            var op2 = _acumulator.Pop();
            _acumulator.Push(op1+op2);
        }

        public int GetResult()
        {
            return _acumulator.Peek();
        }
    }
}
