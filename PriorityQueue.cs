using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class PriorityQueue
    {
        static void Main(string[] args)
        {
            PriorityQueueClass<string> pqc = new PriorityQueueClass<string>();

            pqc.Enqueue("P", 1);
            pqc.Enqueue("S", 3);
            pqc.Enqueue("K", 0);
            pqc.Enqueue("M", 4);

                Console.WriteLine(pqc.Dequeue());
            
        }
    }
}