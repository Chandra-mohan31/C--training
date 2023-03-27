using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AddCharFrontBack
    {
        public AddCharFrontBack() { 
            string s = Console.ReadLine();
            string res = s[s.Length - 1] + s + s[s.Length - 1];
            Console.WriteLine(res);

        }
    }
}
