using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Oops
    {
        public Oops() { }
    private void display()
        {
            Console.WriteLine("Hey");
        }
    public class Test1
        {
            protected internal void display2()
            {
                Console.WriteLine("Hey from Test1");
            }

        }
    }
}
