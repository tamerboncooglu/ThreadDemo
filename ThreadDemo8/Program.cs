using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo8
{
    class Program
    {
        static void Main(string[] args)
        {

            new Thread(Go).Start();
            Console.ReadKey();

        }
        static void Go()
        {
            try
            {
                // ...
                throw null;    // The NullReferenceException will get caught below
                // ...
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Typically log the exception, and/or signal another thread
                // that we've come unstuck
                // ...
            }
        }   // Throws a NullReferenceException
    }
}
