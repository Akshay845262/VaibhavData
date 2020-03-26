using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> MyDic = new Dictionary<int, int>();
            int i;
            Console.WriteLine("enter 5 nos:");
            for (i=1;i<=5;i++)
            {
                int j;
                
                j = Convert.ToInt32(Console.ReadLine());
                MyDic.Add(i, j);
            }

            foreach(var result in MyDic)
            {
                Console.WriteLine(result.ToString());
            }
            Console.WriteLine("Element of MyDic[4] is {0}", MyDic[4].ToString());
            MyDic.Remove(5);
            foreach (var result in MyDic)
            {
                Console.WriteLine(result.ToString());
            }

            ArrayList MyList = new ArrayList();
            for (i = 1; i <= 5; i++)
            {
                MyList.Add(i.ToString());
            }
            Console.WriteLine("No of items in MyList is: " + MyList.Count);
            foreach(var lst in MyList )
            {
                Console.WriteLine(lst.ToString());
            }
            Console.ReadKey();
        }
    }
}
