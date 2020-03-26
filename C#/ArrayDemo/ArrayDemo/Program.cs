using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            int i;
            for(i=0;i<5;i++)
            {
                x[i] = i;
            }
            foreach(int a in x)
            {
                Console.WriteLine(x[a]);
                
            }
            Console.ReadKey();
        }
    }
}
