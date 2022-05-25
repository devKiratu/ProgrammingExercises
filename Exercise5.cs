using System;
using System.Collections.Generic;

namespace ProgrammingExercises
{
    public class Exercise5 
    {
        public static void GetProductOfAllIntsExceptAtIndex(int[] numbers)
        {
            #region old solution
            //var sums = new List<int>();

            //foreach (var num in numbers)
            //{
            //    var sum = 1;
            //    for (var i=0; i<numbers.Length; i++)
            //    {
            //        sum = num != numbers[i]? sum *= numbers[i] : sum *= 1; 
            //    }

            //    sums.Add(sum);

            //}


            //foreach (var num in sums)
            //    Console.WriteLine(num);
            #endregion

            #region more optimal solution t -> O(n), s -> O(1)
            //this solution edits the array in place, assumes this is allowed.
            
            //display input for reference
            Console.Write($"input: [{string.Join(',', numbers)}] ");

            //get the product of all numbers in the array
            var product = 1;
            foreach(var num in numbers)
            {
                product *= num;
            }

            //generate the products array
            for(var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = product / numbers[i];
            }

            //print out the products array alongside initial array
            Console.Write($"=> products: [{string.Join(',', numbers)}]");

            #endregion

        }

    }
}
