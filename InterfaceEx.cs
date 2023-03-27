using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface InterfaceEx
    {
        public void show();

        public void calculate(int age);

        public void display(string name)
        {
            Console.WriteLine(name);
        }
    }

    public class ChildClass : InterfaceEx {
        public void show()
        {
            Console.WriteLine("show");
        }
        public void calculate(int age)
        {
            Console.WriteLine(age);
        }

        public void display(string name)
        {
            Console.WriteLine(name);
        }

        
    }

}
