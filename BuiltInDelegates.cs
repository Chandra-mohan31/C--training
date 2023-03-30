using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //public delegate void PrintEx1(int a);
    public class TestClass
    {
        public int a;

        public TestClass(int a)
        {
            this.a = a;
        }
    }
    internal class BuiltInDelegates
    {

        public BuiltInDelegates() {
            //PrintEx1 p = delegate (int a)
            //{
            //    Console.WriteLine(a);
            //};
            //p(90);
            //PrintEx1 p1 = (int a) => Console.WriteLine(a);
            //p1(89);

            //Action<int> p = (int a) => Console.Write(a);
            //p(90);
            //Action p1 = () => Console.Write("\n hey");
            //p1();

            Func<int, int, int> f1 = delegate (int a, int b)
            {
                return a + b;
            };

            Func<int , int, int> f2 = (a,b) =>  a - b;

            Console.WriteLine(f2(1, 2));

            Console.WriteLine(f1(1, 2));

            Func<int> f3 = () =>  2;
            Console.WriteLine(f3());
            Func<TestClass, int> f4 = (TestClass t) =>
            {
                
                return t.a;
            };
            Console.WriteLine(f4(new TestClass(6)));
            Predicate<int> p1 = (v) => v > 10;

            Predicate<Tuple<int,int>> p3 = (Tuple<int,int> t ) => t.Item1 == t.Item2;
            List<int> li = new List<int>()
            {
                6,7,8
            };
            Predicate<List<int>> p4 = (List<int> li) => (li.All(l => l > 5));


            if (p3(new Tuple<int, int>(2, 1)))
            {
                Console.WriteLine("They are equal");
            }else
            {
                Console.WriteLine("They are not equal");

            }


            if (p4(li))
            {
                Console.WriteLine("They are greater than 5");
            }
            else
            {
                Console.WriteLine("They are smaller than 5");

            }


            Func<long, long, List<long>, IEnumerable<long>> GeneratePrimesRecursively = (number, upperBound, primeFactors) =>
            {
                GeneratePrimesRecursively = null;
                if (upperBound < number)
                {
                    return primeFactors;
                }
                else
                {
                    if (!primeFactors.Any(factor => number % factor == 0)) primeFactors.Add(number);
                    return GeneratePrimesRecursively(++number, upperBound, primeFactors); 
                }
            };



        }
    }
}
