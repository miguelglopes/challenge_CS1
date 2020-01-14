using System;

namespace Test
{
    class Question1
    {
        /*
         * Overloading: ter o mesmo método com vários inputs diferentes. Exemplo:
        */
        static String ToString(int input)
        {
            return input.ToString();
        }
        static String ToString(bool input)
        {
            if (input)
                return "True";
            else
                return "False";
        }

        /*
         * Overrriding: substituir um método de uma class exemplo:
        */
        class Person
        {
            internal String name = "José";

            public virtual string GetName()
            {
                return name;
            }
        }

        class Baby : Person
        {
            public override String GetName()
            {
                return "Baby "+name;
            }
        }

    }
}
