using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsole
{
    public enum roles
    {
        Admin=2,
        User=3,
        System=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Exp(2));
            Console.WriteLine(Math.E*Math.E);

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-3));


            Console.WriteLine("---------------------");
            Console.ReadKey();
            Console.WriteLine(roles.Admin.ToString());
            var Roleofuser = roles.System;
            if(Roleofuser==roles.System        )
            {
                Console.WriteLine("Admin User");
            }
            Console.ReadKey();
            Console.WriteLine("-------------");
            var rnd = new Random();
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(rnd.NextDouble());
            }
            Console.ReadKey();
        }
    }
}
