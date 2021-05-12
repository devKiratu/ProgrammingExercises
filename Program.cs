using System;

namespace ProgrammingExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Q5
            //var numbers = new[] { 1, 7, 3, 4 };
            //Exercise5.GetProductOfAllIntsExceptAtIndex(numbers);

            //Q4
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

            //Q3
            var braces = "{[]()}";
            var braces1 = "{[(])}";

            // Console.WriteLine(braces + "\t" + Exercise3.IsProperlyNested(braces));
            //Console.WriteLine(braces1 + "\t" + Exercise3.IsProperlyNested(braces1));

            //Q1
            var flightLength = 90;
            var movieLengths = new int[] {41, 42, 43, 44, 45, 46};
            Console.WriteLine(Exercise1.AreThereTwoMovies(flightLength, movieLengths));


        }
    }
}
