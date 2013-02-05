using System;

//source : http://www.albahari.com/threading

namespace ThreadSafeUnsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class ThreadUnsafe
    {
        static int _val1 = 1, _val2 = 1;

        static void Go()
        {
            if (_val2 != 0) Console.WriteLine(_val1 / _val2);
            _val2 = 0;
        }
    }

    class ThreadSafe
    {
        static readonly object _locker = new object();
        static int _val1, _val2;

        static void Go()
        {
            lock (_locker)
            {
                if (_val2 != 0) Console.WriteLine(_val1 / _val2);
                _val2 = 0;
            }
        }
    }
}
