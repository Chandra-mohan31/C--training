namespace ConsoleApp2
{
    internal class Program 
    {

        //check this 

        //static int Count(Delegate callback, int[] arr)
        //{
        //    return arr.Count((Func<int, bool>)callback);
        //}

        static void Main(string[] args)
        {

            //new StatementLambdaEx();

            //int[] arr = {1,2,3,4,5,6,7,8,9};
            //var count = arr.Count(num => num % 2 == 0);
            //Console.WriteLine(count);

            //Count(count , arr);

            //new LambdaEx();

            //lambda functions

            //new AnonyomousFuncEx();


            //anonymous functions

            //delegateForSumFunc de = delegate(int a,int b){ return a + b;  };
            //Console.WriteLine(de(1, 3));
            //Print p = delegate (string s) { Console.WriteLine(s); };
            //p("name");
            //delegateWithoutParams dep = delegate () { Console.WriteLine("without arguments"); };
            //dep();

            //------------------

            //mathOperations d1 = de.add;
            //mathOperations d2 = de.sub;
            //mathOperations d3 = de.mul;
            //mathOperations d4 = de.div;
            //mathOperations d5 = d1 + d2 + d3 + d4;

            //Delegate[] arr = d5.GetInvocationList();
            //d5.Invoke(1, 2);

            //Action<int,int> ae = de.add;
            //ae.Invoke(1, 2);

            //Func<int, int, int> fe = de.Diff;
            //fe.Invoke(1, 2);
            //new FileHandlingEx();
            //DelegatesEx de = new DelegatesEx();

            //delegateForSumFunc d1 = de.sum;
            //d1 += de.Diff;

            ////Console.WriteLine(d1.Invoke(1,2));
            //foreach (Delegate d  in d1.GetInvocationList())
            //{
            //    d1(1, 2); 
            //}
            //Console.WriteLine(d1.Invoke(1, 2));

            //Console.WriteLine(d1.Invoke(2, 2));

            //ChildClass c = new ChildClass();
            //c.display("name");
            //c.calculate(20);
            //c.show();
            //InheritAbstractClass ihc = new InheritAbstractClass();
            //ihc.method(1,2);

            //Printer p = new Printer();
            //p.show();
            //p.print();

            //Printer ls = new LaserJet();
            //ls.show();
            //ls.print();

            //Printer of = new Officejet();
            //of.show();
            //of.print();


            //Marks m = new Marks(289,5);
            //Student student = new Student("cm",20,29,2,m);
            //student.display();

            //MethodOverloadingEx me = new MethodOverloadingEx();
            //var spVolvo = new VolvoSports();

            //spVolvo.ABS();
            //spVolvo.SportsVolvo();

            //var Volvo = new Volvo();
            //Volvo.MaxSpeed(60);
            //Volvo.ABS();
            //Program ta = new Program();
            //Console.WriteLine(ta.name);

            //Oops.Test1 op = new Oops.Test1();

            //op.display2();





















            //Generics<string> ge = new Generics<string>("working");
            //Generics<int> ge1 = new Generics<int>(21);
            //Generics<float> ge2 = new Generics<float>(21.7f);
            //GenericMethod gm = new GenericMethod();
            //gm.Test("some");
            //gm.Test(24);
            //CollectionsDemo.ListDemo();
            //HashsetDemo.HashsetDemoFunc();
            //SortedSetDemo.SortedSetDemoFunc();
            //StackDemo.StackAndQueueDemoFunc();

            //Program1 p1 = new Program1("myname",1);
            //Console.WriteLine(p1.getName());
            //Console.WriteLine(p1.getId());



            //int age = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    ExepctionHandling.CheckAge(age);
            //}
            //catch(MyException e)
            //{
            //    Console.WriteLine(e);
            //}
            //ExepctionHandling.Ex_Handling();

            //Triangle t = new Triangle();
            //t.side1 = 10;
            //t.side2 = 20;
            //t.side3 = 30;
            //int a = (int)days.monday;
            //Console.WriteLine(a);

            //p1.displayStudent();
            //p1.getName();
            //foreach (int i in Enum.GetValues(typeof(days)))
            //{
            //    Console.WriteLine($" {i}");
            //}

            //Console.WriteLine(Enum.GetName(typeof(days),3));
            //Console.WriteLine(t.GetPermiter());



            //Program p = new Program();
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Welcome");
            //int[] s = { 1, 2, 3, 4 };
            //int[] s1 = { 3, 4, 5, 6, 7, 9 };
            //int[,] MultArr2 = new int[3, 3];
            //MultArr2[0, 1] = 6;
            //int[,] MultArr = { { 1,2,3}, {4,5,6 } };

            //int[][] jagArr = new int[3][];

            //jagArr[0] = new int[] { 1, 2, 3, 4 };
            //jagArr[1] = new int[] { 11, 34, 67 };
            //jagArr[2] = new int[] { 11, 34, 67,78 };

            //for(int c=0;c<jagArr.Length;c++)
            //{
            //    for(int k = 0; k < jagArr[c].Length; k++)
            //    {
            //        Console.WriteLine(jagArr[c][k]);
            //    }
            //}

            //StatPrintMultiDimensionalArray(MultArr);







        }
        //public void PrintAnArray(int[] ar)
        //{
        //    foreach (int item in ar)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public struct Triangle
        //{
        //    public int side1;
        //    public int side2;
        //    public int side3;
        //    public int GetPermiter()
        //    {
        //        return this.side1+this.side2+this.side3;
        //    }

        //}
        //public static void StatPrintAnArray(int[] ar)
        //{
        //    foreach (int item in ar)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void StatPrintMultiDimensionalArray(int[,] ar)
        //{
        //    for(int i = 0; i < ar.GetLength(0); i++)
        //    {
        //        for(int j = 0;j< ar.GetLength(1); j++)
        //        {
        //            Console.Write((int)ar[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}


    }
}