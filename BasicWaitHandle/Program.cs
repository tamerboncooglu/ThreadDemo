using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace BasicWaitHandle
{
    class Program
    {
        static EventWaitHandle _waitHandle = new AutoResetEvent(false);

        static void Main()
        {
            new Thread(Waiter).Start();
            Thread.Sleep(1000);                  // Pause for a second...
            _waitHandle.Set();                    // Wake up the Waiter.

            Console.ReadKey();
        }

        static void Waiter()
        {
            Console.WriteLine("Waiting...");
            _waitHandle.WaitOne();                // Wait for notification
            Console.WriteLine("Notified");
        }
    }
}
