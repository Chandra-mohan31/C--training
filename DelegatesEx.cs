using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    delegate int delegateForSumFunc(int a, int b);

    delegate void Print(string str);

    delegate void mathOperations(int a, int b);

    delegate void delegateWithoutParams();

    public class DelegatesEx
    {
        public int sum(int a , int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public int Diff(int a,int b)
        {
            Console.WriteLine(a - b);

            return a - b;
        }

        public void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
       public   void sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
       public  void mul(int a,int b)
        {
            Console.WriteLine(a * b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
