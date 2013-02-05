using System;
using System.Collections.Generic;
using System.Threading;

//source : http://www.albahari.com/threading

namespace ThreadSafety
{
    class Program
    {
        static List<string> _list = new List<string>();

        static void Main()
        {
            new Thread(AddItem).Start();
            new Thread(AddItem).Start();
            Console.ReadKey();
        }

        static void AddItem()
        {
            lock (_list) _list.Add("Item " + _list.Count);

            string[] items;
            lock (_list) items = _list.ToArray();
            foreach (string s in items) Console.WriteLine(s);
        }
    }
}
