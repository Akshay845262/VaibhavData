using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Demo
            {
                public static void DemoMethod()
                {
                    for(int i=1;i<=10;i++)
                    {
                        Console.WriteLine("Demo Class");
                        Thread.Sleep(1000);

                    }
                }
            }

    class Sample
            {
                public static void SampleMethod()
                {
                    for(int i=1;i<=10;i++)
                    {
                        Console.WriteLine("Sample Class");
                        Thread.Sleep(1000);

                    }
                }
            }
    class Program
    {
        
        static void Main(string[] args)
        {
            Thread D = new Thread(Demo.DemoMethod);
            D.Start();
            D.Join();
            Thread S = new Thread(Sample.SampleMethod);
            S.Start();
            S.Join();
            
            Console.WriteLine ("After the thread D");
            Console.ReadKey();
           
        }
        
            
    }
}

