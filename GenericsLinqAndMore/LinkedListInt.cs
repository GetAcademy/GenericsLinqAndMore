using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    class LinkedListInt : IEnumerable<int>, IEnumerator<int>
    {
        private IntNode _first;
        private IntNode _current;

        public LinkedListInt()
        {
            _first = null;
        }

        public void Add(int value)
        {
            _first = new IntNode(_first, value);
        }

        public IEnumerator<int> GetEnumerator()
        {
            _current = null;
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (_current == null && _first != null)
            {
                _current = _first;
                return true;
            }
            if (_current.Next == null) return false;
            _current = _current.Next;
            return true;
        }

        public void Reset()
        {
            _current = null;
        }

        public int Current => _current.Value;

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
