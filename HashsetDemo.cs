using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HashsetDemo
    {
        public static void HashsetDemoFunc()
        {
            var data = new HashSet<int>() { 1, 2, 3, 4, 5 };

            data.Add(10);
            data.Add(1);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
