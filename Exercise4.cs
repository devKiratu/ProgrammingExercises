using System;
using System.Collections.Generic;

namespace ProgrammingExercises
{
    public class Exercise4
    { 
        public static int GetIndexOfStartingPoint(string[] words)
        {
            #region initial solution -> t -> O(nlogn) s -> O(n)
            //var helperArray = new string[words.Length];

            //for(var i = 0; i < words.Length; i++) //O(n)
            //{
            //    helperArray[i] = words[i];
            //}

            //Array.Sort(helperArray); //O(nlogn)

            //var index = 0;
            //for(var i = 0; i < words.Length; i++) //O(n)
            //{
            //    if(words[i] == helperArray[0])
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //return index;
            #endregion

            #region solution 2 -> optimizing for space O(1) t >= O(n^2)
            var index = 0;
            var word = words[0];

            for(var i = 1; i < words.Length; i++)
            {
                if(string.Compare( words[i], word) < 0)
                {
                    word = words[i];
                    index = i;
                }
                
            }

            return index;
            
            #endregion
        }
    }

}
