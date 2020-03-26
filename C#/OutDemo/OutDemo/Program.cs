using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    class Demo
    {
        public int square(out int x)
        {
            Console.Write("enter the value for X:");
            x = Convert.ToInt32(Console.ReadLine());
            return (x * x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            int i, j;
            j = d.square(out i);
            Console.WriteLine("Result:{0}", j);
            Console.ReadKey();
        }
    }
}
