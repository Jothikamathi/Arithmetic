/*using System;
namespace MySampleProgramOOPS
{
    class Program
    {
        //entry point of application
        public static void Main()
        {
            /*Array Example
            int[] marks = new int[5];
            marks[0] = 22;
            marks[1] = 24;
            marks[2] = 25;
            marks[3] = 26;
            marks[4] = 30;

            //Looping
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Element of marks  array [{0}] has {1} ", i, marks[i]);
            }
        }
    }
}*/





            










using Arithmetic;
using System;
namespace SampleProgram
{
    class Program
    {
        //entry point of application
        public static void Main()
        {
            Product pro = new Product();
            pro.AddProducts();
            pro.DisplayProductDetails();
            Console.ReadKey();
        }
    }
}
