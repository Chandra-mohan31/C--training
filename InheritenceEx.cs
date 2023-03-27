using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InheritenceEx
    {
        int max_speed = 20;
        public void MaxSpeed(int maxSpeed)
        {
            Console.WriteLine(maxSpeed);
        }
        public void ABS()
        {
            Console.WriteLine("abs is applied");
        }
    }
    public class Volvo : InheritenceEx
    {
        public void ABS()
        {
            Console.WriteLine("Advanced ABS is applied");
        }

    }
    public class VolvoSports: Volvo
    {
        public void SportsVolvo()
        {
            Console.WriteLine("Sporting performnace");
        }
    }
}
