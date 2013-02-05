using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo3
{
    class Program
    {//ThreadSafe
        static bool done;    // Static fields are shared between all threads
        static readonly object locker = new object();

        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            lock (locker)
            {
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
    }
}
