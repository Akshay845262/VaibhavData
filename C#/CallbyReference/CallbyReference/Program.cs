using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbyReference
{
    class ByReference
    {
        public int square(ref int a)
        {
            return a = a * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ByReference r = new ByReference();
            int x, result;

            Console.Write("enter a value for x:");
            x = Convert.ToInt32(Console.ReadLine());
            result = r.square(ref x);
            Console.WriteLine("Result:{0}",result);
            Console.ReadKey();
        }
    }
}
