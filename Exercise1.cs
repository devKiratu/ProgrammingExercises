using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExercises
{
    public class Exercise1
    {
        public static bool AreThereTwoMovies(int flightLength, int[] movieLengths)
        {
            var movieLengthSums = new List<int>();
            foreach (var m in movieLengths)
            {
                
                for (var i = 0; i < movieLengths.Length; i++)
                {
                    var sum = i != Array.IndexOf(movieLengths, m) ? movieLengths[i] + m : 0;
                    if (sum != 0 && !movieLengthSums.Contains(sum))
                    {
                        movieLengthSums.Add(sum);
                    }
                }
            }

            return movieLengthSums.Any(s => s == flightLength);
        }
    }
}
