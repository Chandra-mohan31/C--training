using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract public class AbstractClassesEx
    {
        abstract public void method(int a, int b);

        public void normal_method(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        

    }
    public class InheritAbstractClass :AbstractClassesEx
    {

        public override void method(int a, int b)
        {
            Console.WriteLine(a + b +"abstract class called");
        }

    }

}
