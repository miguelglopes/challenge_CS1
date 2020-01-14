using System;
using System.ComponentModel;
using System.Threading;

namespace Test
{
    class Question8
    {
        public static void CreateAndStartThread1(string name)
        {
            Thread t = new Thread(() => StartHere(name));
            t.Start();
        }

        public static void CreateAndStartThread2(string name)
        {
            var t = new Thread(new ParameterizedThreadStart(StartHere));
            t.Start(name);
        }

        public static void CreateAndStartThread3(string name)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                StartHere(name);
            });

            bw.RunWorkerAsync();

        }


        private static void StartHere(object name)
        {
            Console.WriteLine("just created thread " + name.ToString());
        }

    }
}
