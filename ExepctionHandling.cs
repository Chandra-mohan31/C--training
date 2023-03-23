using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExepctionHandling
    {
        public static void Ex_Handling()
        {
            int a = 10;
            int b = 0;
            int c;
            int[] arr = {2, 2, 1};
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                Console.WriteLine("Finally is called");
            }
            
        }
        public static void CheckAge(int age)
        {
            if(age < 18)
            {
                throw new MyException("Sorry you must be 18 for voting");
            }
        }
    }
    public class MyException:Exception

    {
        public MyException(string myMessage):base(myMessage) { 
        
        }    
    }
}
