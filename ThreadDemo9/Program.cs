using System;
using System.Threading.Tasks;

//source : http://www.albahari.com/threading

namespace ParallelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();

            Parallel.For(0, 100, i => Foo(i));

            Console.ReadKey();
        }

        private static void Hello()
        {
            Parallel.ForEach("Hello, world", (c, state, i) =>
            {
                Console.WriteLine(c.ToString() + i);
            }); 
        }

        private static void Foo(object o)
        {
            Console.WriteLine(o.ToString());
        }
    }
}
