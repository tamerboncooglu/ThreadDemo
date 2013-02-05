using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);          // Kick off a new thread
            t.Start();                               // running WriteY()

            // Simultaneously, do something on the main thread.
            Console.WriteLine("X Started");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("x");
            }
            Console.WriteLine("");
            Console.WriteLine("X Finished");
            Console.ReadKey();
        }

        static void WriteY()
        {
            Console.WriteLine("Y Started");
            for (int i = 0; i < 100; i++) 
            {
                Console.Write("y");
            }
            Console.WriteLine("");
            Console.WriteLine("Y Finished");
        }
    }
}
