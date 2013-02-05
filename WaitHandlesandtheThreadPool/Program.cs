using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace WaitHandlesandtheThreadPool
{
    class Program
    {
        static ManualResetEvent _starter = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            RegisteredWaitHandle reg = ThreadPool.RegisterWaitForSingleObject
                             (_starter, Go, "Some Data", -1, true);
            Console.WriteLine("waiting 5 seconds");
            Thread.Sleep(5000);
            Console.WriteLine("Signaling worker...");
            _starter.Set();
            Console.ReadLine();
            reg.Unregister(_starter);    // Clean up when we’re done.
            Console.ReadKey();
        }
        public static void Go(object data, bool timedOut)
        {
            Console.WriteLine("Started - " + data);
            // Perform task...
        }
    }
}
