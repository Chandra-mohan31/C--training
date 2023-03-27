using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SwapFirstLast
    {
        
        public SwapFirstLast() {
            string val = Console.ReadLine();
            Console.WriteLine(val.Substring(val.Length - 1) + val.Substring(1, val.Length - 2) + val.Substring(0,1));
        }
    }
}
