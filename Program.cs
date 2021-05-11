using System;

namespace ProgrammingExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var numbers = new[] { 1, 7, 3, 4 };
            //Exercise5.GetProductOfAllIntsExceptAtIndex(numbers);

            var words = new string[]
            {
            "ptolemaic",
            "retrograde",
            "supplant",
            "undulate",
            "xenoepist",
            "asymptote", 
            "babka",
            "banoffee",
            "engender",
            "karpatka",
            "othellolagkage",
            };

            //var index =  Exercise4.GetIndexOfStartingPoint(words);
            //   Console.WriteLine("You started at word with index" + index);


            var braces = "{[]()}";
            var braces1 = "{[(])}";

            Console.WriteLine(braces + "\t" + Exercise3.IsProperlyNested(braces));
            Console.WriteLine(braces1 + "\t" + Exercise3.IsProperlyNested(braces1));


        }
    }

}
