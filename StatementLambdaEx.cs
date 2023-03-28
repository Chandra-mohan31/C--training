using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StatementLambdaEx
    {

        public StatementLambdaEx()
        {
            var result = (int x, int y) =>
            {
                int total = 0;
                total = x + y;
                return total;
            };

            Console.WriteLine(result(1,2));
        }

        
    }
}
