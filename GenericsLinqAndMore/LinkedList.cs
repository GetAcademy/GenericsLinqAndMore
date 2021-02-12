using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    class LinkedList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private Node<T> _first;
        private Node<T> _current;

        public LinkedList(params T[] values)
        {
            _first = null;
            foreach (var value in values)
            {
                Add(value);
            }
        }

        public void Add(T value)
        {
            _first = new Node<T>(_first, value);
        }

        public IEnumerator<T> GetEnumerator()
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

        public T Current => _current.Value;

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
