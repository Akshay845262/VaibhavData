using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassLibrary
{
    public class Maths : IMaths
    {
        private IRandomClass rndClass = null;
        public Maths(IRandomClass rnd = null)
        {
            rndClass = rnd;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Divide(int x, int y)
        {
            return x / y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int calc(int a, int b)
        {
            //RandomClass rc = new RandomClass();
            int rndNumber = rndClass.getRandomNumber();
            if(rndNumber>5)
            {
                return Mul(a, b);
            }
            else
            {
                return Add(a, b);
            }
        }
    }
}
