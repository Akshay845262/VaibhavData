using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int k;
            Console.WriteLine("Enter elements that you want to sort");
            for(k=0;k<5;k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
