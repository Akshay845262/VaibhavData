using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleDemo
{
    delegate int NumberChanger(int n);

    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            //NumberChanger nc3 = new NumberChanger(getNum);
            nc1(25);
            Console.WriteLine("Value of Num:{0}", getNum());
            nc2(10);
            Console.WriteLine("Value of Num:{0}", getNum());
            Console.ReadKey();
        }
    }
}
