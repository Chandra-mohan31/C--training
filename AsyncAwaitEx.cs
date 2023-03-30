using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class AsyncAwaitEx2
    {
        public AsyncAwaitEx2()
        {
        }
        public static async Task<string> Method1()
        {
            Console.WriteLine("Method 1 started");
            await Task.Delay(3000);
            return "Method 1 ended";
        }
        public static async Task<string> Method2()
        {
            Console.WriteLine("Method 2 started");
            await Task.Delay(1000);

            return "Method 2 ended";
        }
        public static async Task<string> Method3()
        {
            Console.WriteLine("Method 3 started");
            await Task.Delay(1000);
            return "Method 3 ended";
        }

        public static async Task<int> MethodA()
        {
            int num = 0;
            Console.WriteLine("In MethodA..");
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Executing method a...");
                    num++;
                }
            });
            
            Console.WriteLine("end of the method a");
            return num;
        }

        public static async Task b()
        {
            Console.WriteLine("start of b");
            Console.WriteLine("end of b");


        }

        public static async Task MethodC(int number)
        {
            Console.WriteLine("Start of MethodC");
            
            Console.WriteLine($"Number from methodA is : {number}");
        }
    }
    public class AsyncAwaitEx
    {
        public AsyncAwaitEx()
        {
            
        }

        public static async void Fn1()
        {
            Console.WriteLine("Upload started!");
            await Task.Delay(3000);

            Console.WriteLine("Upload Done!");

        }
        public static void Fn2()
        {
            Console.WriteLine("New function stated!");
            Console.WriteLine("New function ended!");

        }

        public static async Task<int> ReturnNum(int a)
        {
            string reqString = await returnName();
            Console.WriteLine($"{reqString}");
            Console.WriteLine("started return num");
            
            await Task.Delay(2000);
            

            return a;
        }

        public static async Task<string> returnName()
        {
            await Task.Delay(5000);
            return "name";
        }

        public static async Task<string> dummyMethod()
        {
            return "dummy";
        }
    }
    }

