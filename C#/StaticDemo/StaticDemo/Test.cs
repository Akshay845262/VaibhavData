using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    static class Test
    {
        public static int i;
        public static void showMsg()
        {
            Console.WriteLine("i=" + i);
        }
        public static int Square(int c)
        {
            return (c * c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.showMsg();
            int input;

            Test.i = 100;
            Console.WriteLine("Square of i is:{0}", (Test.i*Test.i));

            Console.Write("Enter value for ");
            input = Convert.ToInt16(Console.ReadLine());

            int output = Test.Square(input);

            Console.WriteLine("Square of Given Number is:{0}", output);
            Console.ReadKey();
        }
    }
}
