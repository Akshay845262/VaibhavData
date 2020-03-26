using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            calc calc = new calc();
            Console.Write("Enter Value for i:");
            i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value for j:");
            j = Convert.ToInt32(Console.ReadLine());

            k = calc.add(i, j);
            Console.WriteLine("Result:{0}", k);

            Console.ReadKey();
        }
    }
}
