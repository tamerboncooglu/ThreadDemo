using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo4
{
    class Program
    {
        static void Main(string[] args)
        {//Creating and Starting Threads
            Thread t = new Thread(new ThreadStart(Go));

            t.Start();   // Run Go() on the new thread.
            Go();        // Simultaneously run Go() in the main thread.
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("hello!");
        }
    }
}
