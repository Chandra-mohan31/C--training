using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SortedSetDemo
    {
        public static void SortedSetDemoFunc()
        {
            var exampleIntegerSet = new SortedSet<int>() { 7,8,5,3,0,8,8};
            var exampleStringSet = new SortedSet<string>() { "hey", "hi", "ad" };

            foreach (var item in exampleStringSet)
            {
                Console.WriteLine(item);
            }
            foreach (var item in exampleIntegerSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
