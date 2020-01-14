using System;

namespace Test
{
    class Question4
    {
        public static string ReverseString(string input)
        {
            if (input.Length <= 0 || input == null)
                return null;

            char[] inputArr = input.ToCharArray();
            Array.Reverse(inputArr);
            return new String(inputArr);
        }
    }
}
