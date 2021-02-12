using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    class Dummy<T>
    {
        public Dummy(T t)
        {
            
        }
        
        public static void DoSomething<U>()
        {
            Console.WriteLine(typeof(U).FullName);
        }
    }

    class DummyString : Dummy<string>
    {
        public DummyString(string s) : base(s)
        {
            
        }
    }
}
