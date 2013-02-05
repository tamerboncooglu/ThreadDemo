using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo7
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            worker.Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
    }
}
