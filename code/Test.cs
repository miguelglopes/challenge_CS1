using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Question4.ReverseString("adeus"));
            Console.WriteLine(Question5.ReverseString("ola"));
            Console.WriteLine(Question6.ReverseString("test sentence ola adeus"));
            Console.WriteLine(Question7.ReverseString("test sentence ola adeus"));

            Question8.CreateAndStartThread1("Thread1");
            Question8.CreateAndStartThread2("Thread2");
            Question8.CreateAndStartThread3("Thread3");

            Question9.Test();


            Console.ReadLine();
        }
    }
}
