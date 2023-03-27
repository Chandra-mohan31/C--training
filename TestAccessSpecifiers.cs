using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TestAccessSpecifiers
    {
        //public TestAccessSpecifiers() { }
        protected string name = "CM";
        protected void method1(string message)
        {
            Console.WriteLine(message);
        }
    }
}
