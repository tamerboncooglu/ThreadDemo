using System;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadDemo5
{
    class Program
    {
        static void Main()
        {//Passing Data to a Thread
            new Thread(() =>
            {
                Console.WriteLine("I'm running on another thread!");
                Console.WriteLine("This is so easy!");
            }).Start();
            Console.ReadKey();
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
