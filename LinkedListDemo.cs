using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LinkedListDemo
    {

        public static void LinkedListDemoFunc()
        {
            var myLinkedList = new LinkedList<int>();
            var newLinkedList = new LinkedList<int>();
            myLinkedList.AddLast(1);
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(2);
          
           
            
            foreach (var item in myLinkedList)
            {
                if(item == 2)
                {
                    newLinkedList.AddLast(10);
                }
                newLinkedList.AddLast(item);
            }
            foreach (var item in newLinkedList)
            {
                Console.WriteLine(item);
            }


            //for(LinkedListNode<int> i = newLinkedList.First; i != null; i = i.Next)
            //{
            //    if(i.Value == 10)
            //    {

            //        newLinkedList.AddBefore(4);
            //    }
            //}

        }
    }
}
