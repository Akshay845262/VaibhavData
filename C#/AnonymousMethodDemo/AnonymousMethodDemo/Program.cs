using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodDemo
{
    class Program
    {
        delegate void DelegateName(int n);
        delegate int Increment(int n);

        static DelegateName dm = delegate (int x)
         {
             Console.WriteLine("Anonymous Method:getting parameter{0}", x);
         };
        static Increment incr = count => count + 3;
        static Increment incry = count =>
        {
            int local = count + 2;
            Console.WriteLine("from anonymous method block");
            return local + 2;
        };

        static void Main(string[] args)
        {
            dm(10);
            int x = 0;
            x = incr(x);
            Console.WriteLine(x);
            int y = 0;
            y = incry(y);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
