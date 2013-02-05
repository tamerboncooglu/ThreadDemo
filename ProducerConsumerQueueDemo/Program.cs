using System;

//source : http://www.albahari.com/threading

namespace ProducerConsumerQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ProducerConsumerQueue q = new ProducerConsumerQueue())
            {
                q.EnqueueTask("Hello");
                for (int i = 0; i < 10; i++) q.EnqueueTask("Say " + i);
                q.EnqueueTask("Goodbye!");
            }

            // Exiting the using statement calls q's Dispose method, which
            // enqueues a null task and waits until the consumer finishes.
        }
    }
}
