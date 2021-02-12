using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsLinqAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqDemo();
            //ExtensionMethodDemo();
            //BuilderPatternDemo();
            //GenericMethodDemo();
            //LinkedListIntDemo();
            //LinkedListGenericsDemo();
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

        private static void LinqDemo()
        {
            IQueryable<Person> x;

            var people = new List<Person>
            {
                new Person("Per", "Olsen"),
                new Person("Pål", "Olsen"),
                new Person("Espen", "Hansen"),
                new Person("Terje", "Hansen"),
            };

            var html = people.Aggregate("",
                ((tmpHtml, person) => tmpHtml + $"<li>{person.FirstName}</li>")
            );
            Console.WriteLine(html);

            var first = people.First();
            var firstPer = people.FirstOrDefault(p => p.FirstName == "Per");
            var last = people.Last();

            var sum = new[] {1, 2, 3}.Sum();
            var min = new[] {1, 2, 3}.Max();


            var hansens = people.Where(p => p.LastName == "Hansen");

            var firstNames = people.Select(p => p.FirstName);

            var firstNamesOfHansens =
                people
                    .Skip(1)
                    //.Take(10)
                    .Where(p => p.LastName == "Hansen")
                    .OrderBy(p => p.LastName)
                    .Select(p => p.FirstName)
                    .OrderBy(fn => fn);

            var firstNamesOfHansens2 =
                from p in people
                where p.LastName == "Hansen"
                orderby p.LastName
                select p.FirstName;

        }

        private static void ExtensionMethodDemo()
        {
            var isTerje1 = StringExtensions.IsTerje("Terje");
            var isTerje2 = "Terje".IsTerje();
        }

        private static void BuilderPatternDemo()
        {
            var result = new Calculator(5)
                .Add1()
                .Double()
                .Mod3()
                .Add1()
                .Value;
            //StringBuilder

            //var html = new HtmlBuilder()
            //    .Add("div")
            //    .InnerAdd("img")
            //    .Out()
            //    .Add("h2");
        }

        private static void GenericMethodDemo()
        {
            Dummy<object>.DoSomething<string>();
            Dummy<object>.DoSomething<IntNode>();
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
        }

        private static void LinkedListGenericsDemo()
        {

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
