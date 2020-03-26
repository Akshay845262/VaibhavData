using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Program
    {
        
        public delegate void Swap(int no1, int no2);

        static void Main(string[] args)
        {
            
            int num1, num2;
            Console.WriteLine("Enter two Nos");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers Before Swapping:"+ num1+"\t"+ num2);
            Swap swp = new Swap (SwapNumber);
            swp(num1,num2);  
            Console.ReadKey();


        }
        public static void SwapNumber(int num1,int num2)
        {
            
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Numbers Before Swapping:"+ num1+"\t"+ num2);

        }
       
    }
}
