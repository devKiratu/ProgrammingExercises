using System;
using System.Collections.Generic;

namespace ProgrammingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numbers = new[] {1,7,3,4};

            var sums = new List<int>();

            foreach (var num in numbers)
            {
                var sum = 1;
                for (var i=0; i < numbers.Length; i++)
                {
                    sum = num != numbers[i] ? sum *= numbers[i] : sum *= 1; 
                }

                sums.Add(sum);

            }


            foreach (var num in sums)
                Console.WriteLine(num);

        }
    }
}
