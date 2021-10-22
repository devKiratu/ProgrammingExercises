using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProgrammingExercises
{
    public class Exercise3
    {
        public static bool IsProperlyNested(string braces)
        {
            ////var regex = @"^\{[(\[\])(\(\))]\}$";
            //var regex = @"^\{\[\]\(\)}$";
            //return Regex.IsMatch(braces, regex);

            var holder = new Stack<char>();

            foreach (var c in braces)
            {
                if (c == '(')
                {
                    holder.Push(')');
                }
                else if (c == '{')
                {
                    holder.Push('}');
                }
                else if (c == '[')
                {
                    holder.Push(']');
                }
                else if (holder.Count == 0 || c != holder.Pop())
                {
                    return false;
                }
            }
            return holder.Count == 0;


        }
    }

}
