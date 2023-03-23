using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CollectionsDemo
    {
        public static void ListDemo()
        {
            var ListDemo = new List<string>();

            ListDemo.Add("Hello");
            ListDemo.Add("Hey");
            ListDemo.Add("Hi");

            foreach (var item in ListDemo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
