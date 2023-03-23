using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Constructor
    {
        public string name;
        public int id;
        public Constructor(string name,int id)
        {
            this.name = name;   
            this.id = id;
        }
        public string getName()
        {
            return this.name;
        }
       public int getId() {
        return this.id;
        }   
    }
}
