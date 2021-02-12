using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    class Calculator
    {
        public int Value { get; private set; }

        public Calculator(int value)
        {
            Value = value;
        }

        public Calculator Double()
        {
            Value *= 2;
            return this;
        }

        public Calculator Add1()
        {
            Value++;
            return this;
        }

        public Calculator Mod3()
        {
            Value = Value % 3;
            return this;
        }
    }
}
