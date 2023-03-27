using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DictionaryDemo
    {
        public static void DictionaryDemoFunc()
        {
            Dictionary<int,string> d = new Dictionary<int, string>();
            d.Add(1, "abc");
            d.Add(2, "bcd");
            d[1] = "hey";
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }

            SortedDictionary<string, string> sd = new SortedDictionary<string, string>();
            sd.Add("hi", "hello");
            sd.Add("hey", "everyone");
            sd.Add("Lion", "King");
            sd.Add("1", "King");
            sd.Add("2", "King");
            foreach (var item in sd)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            foreach( var item in sd.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");

            }


        }
    }
}
