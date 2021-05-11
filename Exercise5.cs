using System;
using System.Collections.Generic;

namespace ProgrammingExercises
{
    public class Exercise5 
    {
        public static void GetProductOfAllIntsExceptAtIndex(int[] numbers)
        {
            var sums = new List<int>();
            
            foreach (var num in numbers)
            {
                var sum = 1;
                for (var i=0; i<numbers.Length; i++)
                {
                    sum = num != numbers[i]? sum *= numbers[i] : sum *= 1; 
                }

                sums.Add(sum);

            }


            foreach (var num in sums)
                Console.WriteLine(num);

        }

    }
}
