using System;
using System.Collections.Generic;

namespace ProgrammingExercises
{
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
