namespace ConsoleApp2
{
    internal class Program
    {
   
        //public enum days
        //{
        //    monday,tuesday,wednesday,thursday,friday,saturday,sunday
        //}
        static void Main(string[] args)


        {

            Program1 p1 = new Program1("myname",1);
            Console.WriteLine(p1.getName());
            Console.WriteLine(p1.getId());



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