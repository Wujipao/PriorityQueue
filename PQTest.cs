using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class PQTest
    {
        static void Main(string[] args)
        {
            PriorityQueueArray<string> pq = new PriorityQueueArray<string>(5);

            pq.Enqueue("hey", 9);
            pq.Enqueue("hello", 2);
            pq.Enqueue("ty", 3);
            pq.Enqueue("t", 1);

            pq.Dequeue();

            pq.Display();
        }
    }
}
