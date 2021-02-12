using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    class IntNode
    {
        public IntNode Next { get; }
        public int Value { get; }

        public IntNode(IntNode next, int value)
        {
            Next = next;
            Value = value;
        }
    }
}
