using System;

namespace GenericsLinqAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListIntDemo();
            /*
             * LinkedListInt
             * LinkedList med generics
             * BuilderPattern (og hva er design patterns)
             * Extension methods
             * LINQ
             *  - projeksjon og seleksjon (map og filter)
             *  - method syntax vs query syntax
             *  - aggregeringer
             *  - sortering og gruppering
             */
        }

        private static void LinkedListIntDemo()
        {
            var list = new LinkedListInt(1, 2, 3);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

            var list2 = new LinkedList<string>("a", "b", "c");
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            foreach (var value in list2)
            {
                Console.WriteLine(value);
            }
        }
    }
}
