using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

//source : http://www.albahari.com/threading

namespace SynchronizationContexts
{
    [Synchronization]
    public class AutoLock : ContextBoundObject
    {
        public void Demo()
        {
            Console.Write("Start...");
            Thread.Sleep(1000);           // We can't be preempted here
            Console.WriteLine("end");     // thanks to automatic locking!
        }
    }

    class Program
    {
        public static void Main()
        {
            AutoLock safeInstance = new AutoLock();
            new Thread(safeInstance.Demo).Start();     // Call the Demo
            new Thread(safeInstance.Demo).Start();     // method 3 times
            safeInstance.Demo();                        // concurrently.

            Console.ReadKey();
        }
    }
}
