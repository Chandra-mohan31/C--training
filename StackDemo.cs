using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StackDemo
    {
        public static void StackAndQueueDemoFunc()
        {
            Stack<string> st1 = new Stack<string>();
            st1.Push("hey");
            st1.Push("hi");
            string tmp;
            while(st1.Count !=0)
            {
                Console.Write(st1.Pop() + "|");
                if(st1.TryPeek(out tmp))
                {
                    Console.WriteLine("Peek element: " , tmp);
                }
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            while(queue.Count !=0)
            {
                Console.Write(queue.Dequeue() + "|");
            }


        }
    }
}
