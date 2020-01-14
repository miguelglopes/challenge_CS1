using System.Text;

namespace Test
{
    class Question7
    {
        public static string ReverseString(string input)
        {
            if (input.Length <= 0 || input == null)
                return null;

            //assuming no punctuation, only words asnd spaces

            StringBuilder output = new StringBuilder();
            string[] inputArr = input.Split(' ');
            for (int i = inputArr.Length - 1; i > -1; i--)
            {
                output.Append(inputArr[i]);
                output.Append(" ");
            }
            return output.ToString();
        }
    }
}
