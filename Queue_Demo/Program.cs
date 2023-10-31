using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

             queue queue = new queue(5);

                // Enqueue elements into the queue
                queue.Enqueue(10);
                queue.Enqueue(30);
                queue.Enqueue(50);

                // Dequeue elements and display them
                Console.WriteLine("=====Queue Elements are====:");
                while (!queue.IsEmpty())
                {
                    int element = queue.Dequeue();
                    Console.WriteLine(element);

                }
                Console.ReadLine();
            }
        }
    }

