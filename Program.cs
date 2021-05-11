using System;
using System.Collections.Generic;

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

           var index =  Exercise4.GetIndexOfStartingPoint(words);
                Console.WriteLine("You started at word with index" + index);


        }
    }

    public class Exercise4
    { 
        public static int GetIndexOfStartingPoint(string[] words)
        {
            var unsortedWords = new List<string>();

            foreach (var word in words)
                unsortedWords.Add(word);

            Array.Sort(words);
            return unsortedWords.IndexOf(words[0]);
        }
    }

}
