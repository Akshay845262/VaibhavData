using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassLibrary
{
    interface IMaths
    {
        int Add(int a, int b);
        int Mul(int a, int b);

        int Sub(int a, int b);
        float Divide(int a, int b);
    }
}
