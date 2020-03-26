using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassLibrary
{
    public class RandomClass : IRandomClass
    {
        public int getRandomNumber()
        {
            return new Random().Next(1, 10);                        
        }
    }
}
