using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo6
{
    class Program
    {
        static void Main(string[] args)
        {
            nonDeterministic();
            deterministic();
            
            Console.ReadKey();
        }

        private static void deterministic()
        {
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => Console.Write(temp)).Start();
            }
        }

        private static void nonDeterministic()
        {
            for (int i = 0; i < 10; i++)
                new Thread(() => Console.Write(i)).Start();
        }
    }
}
