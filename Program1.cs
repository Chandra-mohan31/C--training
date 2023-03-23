using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program1
    {
        string name;
        int id;
        
        public Program1(string name,int id)
        {
            this.name = name;
            this.id = id;
            

        }

        public string getName()
        {
            return this.name;
        }
        public int getId()
        {
            return this.id;
        }

        ~Program1()
        {
            Console.WriteLine("Destructor called");
        }
      

        
       


    }


}
