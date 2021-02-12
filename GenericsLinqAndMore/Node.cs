using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    class Node<T>
    {
        public Node<T> Next { get; }
        public T Value { get; }

        public Node(Node<T> next, T value)
        {
            Next = next;
            Value = value;
        }
    }
}
