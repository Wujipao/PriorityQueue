using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class PriorityQueueClass<T>
    {
        SortedList<int, Queue<T>> queue = new SortedList<int, Queue<T>>();

        public void Enqueue(T item, int priority)
        {
            if (!queue.ContainsKey(priority))
            {
                queue.Add(priority, new Queue<T>());
            }
            queue[priority].Enqueue(item);
        }
        public T Dequeue()
        {
            if (queue.Count == 0)
            {
                throw new Exception("Queue is empty.");
            }
            var firstKey = queue.Keys.Min();
            var item = queue[firstKey].Dequeue();

            if (queue[firstKey].Count == 0)
            {
                queue.Remove(firstKey);
            }
            return item;
        }
        public bool isEmpty()
        {
            return queue.Count == 0;
        }
    }
}
