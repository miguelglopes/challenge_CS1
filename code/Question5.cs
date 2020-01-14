
namespace Test
{
    class Question5
    {
        public static string ReverseString(string input)
        {
            if (input.Length <= 0 || input == null)
                return null;

            return input[input.Length - 1] + ReverseString(input.Substring(0, input.Length - 1));
        }


    }
}
