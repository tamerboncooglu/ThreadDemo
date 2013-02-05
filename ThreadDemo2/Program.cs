using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo2
{
    class Program
    {
        bool done;
        static void Main(string[] args)
        {
            Program tt = new Program();   // Create a common instance
            new Thread(tt.Go).Start();
            tt.Go();
            
            Console.ReadKey();
        }

        void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}
