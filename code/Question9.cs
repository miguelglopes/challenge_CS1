using System;
using System.Collections.Concurrent;

namespace Test
{
    class Question9 : ConcurrentQueue<int>
    {

        public static ConcurrentQueue<int> getNewQueue()
        {
            return new ConcurrentQueue<int>();
        }

        public void fillQueue()
        {
            Random randNum = new Random();
            for (int i = 0; i < 999; i++)
            {
               this.Enqueue(randNum.Next(0, 1000));
            }
        }

        public void doThis()
        {
            int temp;
            foreach(int i in this)
            {
                while (this.TryDequeue(out temp))
                    Console.WriteLine(temp);
            }
        }

        public static void Test()
        {
            Question9 q9 = new Question9();
            q9.fillQueue();
            q9.doThis();
        }

    }
}
