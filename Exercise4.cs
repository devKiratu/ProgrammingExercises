using System;
using System.Collections.Generic;

namespace ProgrammingExercises
{
    public class Exercise4
    { 
        public static int GetIndexOfStartingPoint(string[] words)
        {
            #region initial solution -> t -> O(nlogn) s -> O(n)
            var helperArray = new string[words.Length];

            for(var i = 0; i < words.Length; i++) //O(n)
            {
                helperArray[i] = words[i];
            }

            Array.Sort(helperArray); //O(nlogn)

            var index = 0;
            for(var i = 0; i < words.Length; i++) //O(n)
            {
                if(words[i] == helperArray[0])
                {
                    index = i;
                    break;
                }
            }

            return index;
            #endregion
        }
    }

}
