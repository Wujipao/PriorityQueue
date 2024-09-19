using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class PriorityQueueArray<T>
    {
        private T[] value;
        private int[] priority;
        private int count;
        private int size;

        public PriorityQueueArray(int size)
        {
            this.size = size;
            this.value = new T[size];
            this.priority = new int[size];
            this.count = 0;
        }
        public bool ifEmpty() //to check if empty
        {
            return count == 0;
        }
        public bool ifFull() //to check if full
        {
            return count == size;
        }
        public void Enqueue(T val, int prio)
        {
            if (ifFull())
            {
                throw new Exception("Queue is full.");
            }
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (priority[i] > prio)
                {
                    value[i + 1] = value[i];
                    priority[i + 1] = priority[i];
                }
                else
                {
                    break;
                }
            }
            value[i + 1] = val;
            priority[i + 1] = prio;
            count++;
        }
        public T Dequeue()
        {
            if (ifEmpty())
            {
                throw new Exception("Queue is empty.");
            }
            T dequeued = value[0];
            
            for (int i = 0; i < count - 1; i++)
            {
                value[i] = value[i + 1];
                priority[i] = priority[i + 1];
                
            }
            count--;
            return dequeued;
        }
        public void Display()
        {
            if (ifEmpty())
            {
                Console.WriteLine("Priority Queue is empty.");
                return;
            }

            Console.WriteLine("Priority Queue elements:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Element: {value[i]}, Priority: {priority[i]}");
            }
        }
    }
}
