using System.Text.RegularExpressions;

namespace ProgrammingExercises
{
    public class Exercise3
    {
        public static bool IsProperlyNested(string braces)
        {
            //var regex = @"^\{[(\[\])(\(\))]\}$";
            var regex = @"^\{\[\]\(\)}$";
            return Regex.IsMatch(braces, regex);
            

        }
    }

}
