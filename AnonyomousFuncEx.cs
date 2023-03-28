using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    delegate int add(int a, int b);
    internal class AnonyomousFuncEx
    {

        public AnonyomousFuncEx()
        {
            //anonymous objects
            //var anonymousObj = new { name = "hey", id = 1 };
            //Console.WriteLine(anonymousObj.name);

            //lambda functions

            //add sum = (num1, num2) => num1 + num2;
            //Console.WriteLine(sum(1, 5));

            //var lamTest = () => Console.WriteLine("hey");
            //lamTest();

            //var sumtest = (int a,int b) => a + b;
            //sumtest += (int a, int b) => a - b;

            //foreach (Delegate item in sumtest.GetInvocationList())
            //{
            //    Console.WriteLine(item.DynamicInvoke(1, 6));

            //}


            //---------------

            var square = (int a) => (a * a);
            List<int> li = new List<int>() { 1,2,3,4,5,6};

            //foreach (var item in li)
            //{
            //    Console.WriteLine(square(item));
            //}


            //------------------
            List<int> li1 = new List<int>() { 1,2,3,4,5,6,10};
            List<int> numbersDivisibleByFive = li1.FindAll(n => n % 5 == 0);

            foreach (var item in numbersDivisibleByFive)
            {
                Console.WriteLine(item);
            }

            List<string> lisStr = new List<string>() { "abc", "bcd", "def" };
            List<string> ascOrder = lisStr.OrderBy(x => x).ToList();
            
            List<string> ContainsA = lisStr.FindAll(str => str.Contains("a"));
            foreach (var item in ContainsA)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(5, "hey");
            dict.Add(6, "everyone");
            dict.Add(7, "add");
            
            foreach (var item in dict.OrderBy(x => x.Value).ToList())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            //order based on key in desc order
            foreach (var item in dict.OrderBy(x => x.Key * -1).ToList())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            //order based on values in desc order
            foreach (var item in dict.OrderByDescending(x => x.Value).ToList())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
