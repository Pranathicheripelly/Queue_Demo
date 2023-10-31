using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Demo
{
    internal class queue
    {

        
        private int[] elements;
        private int front;
        private int rear;
        private int capacity;

        public queue(int size)
        {
            capacity = size;
            elements = new int[size];
            front = 0;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return front > rear;
        }

        public bool IsFull()
        {
            return rear == capacity - 1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue.");
            }
            else
            {
                elements[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return -1; // You can choose any default value
            }
            else
            {
                int item = elements[front++];
                return item;
            }
        }

        public string PrintQueue()
        {
            string result = "";

            for (int i = front; i <= rear; i++)
            {
                result += elements[i] + " ";
            }

            return result;
        }
    }
}

