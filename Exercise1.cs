using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingExercises
{
    public class Exercise1
    {
        public static bool AreThereTwoMovies(int flightLength, int[] movieLengths)
        {
            #region old solution, very inefficient t -> >O(n^3)
            //var movieLengthSums = new List<int>();
            //foreach (var m in movieLengths)
            //{

            //    for (var i = 0; i < movieLengths.Length; i++)
            //    {
            //        var sum = i != Array.IndexOf(movieLengths, m) ? movieLengths[i] + m : 0;
            //        if (sum != 0 && !movieLengthSums.Contains(sum))
            //        {
            //            movieLengthSums.Add(sum);
            //        }
            //    }
            //}

            //return movieLengthSums.Any(s => s == flightLength);
            #endregion

            #region more optimal solution t -> O(n)
            var moviePairs = new Dictionary<int, int>();

            foreach(var m in movieLengths)
            {
                //is the current item a pair to a number we've met before?(is it in the list of missing pairs)
                if(moviePairs.TryGetValue(m, out _))
                {
                    return true;
                }
                else
                {
                    //add current item's pair to pairs list
                    var missingPair = flightLength - m;
                    moviePairs.TryAdd(missingPair,1);
                }
            }
            return false;
            #endregion
        }
    }
}
