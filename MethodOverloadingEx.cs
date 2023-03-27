using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MethodOverloadingEx
    {
        public  MethodOverloadingEx() {
            OverLoadingEx("NAME",DAYS.monday);
        }

        enum DAYS { monday,tuesday,wednesday,friday}

        private static void OverLoadingEx(string name, DAYS day)
        {
            Console.WriteLine($"your name is {name} , today is {day}");
            Type T = day.GetType();

            Console.WriteLine(T.Name);
        }
        private static void OverLoadingEx(string name,int id)
        {
            Console.WriteLine($"your name is {name} and your id is {id}");
        }
        private static void OverLoadingEx(int projectId,int miniId)
        {
            Console.WriteLine($"your projectId is {projectId} and your id is {miniId}");

        }
    }
}
