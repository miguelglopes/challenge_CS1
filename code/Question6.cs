using System;
using System.Linq;


namespace Test
{
    class Question6
    {
        public static string ReverseString(string input)
        {
            if (input.Length <= 0 || input == null)
                return null;

            //assuming no punctuation, only words asnd spaces
            return String.Join(" ", input.Split(' ').Reverse());
        }
    }
}
