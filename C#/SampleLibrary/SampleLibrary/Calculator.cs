using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public class Calculator
    {
        public double Addition(double x, double y)
        {
            return (x + y);
        }
        public double Subtraction(double x, double y)
        {
            return (x - y);
        }
        public double Multiplication(double x, double y)
        {
            return (x * y);
        }
        public double Division(double x, double y)
        {
            return (x / y);
        }
    }
    interface ITest
    {
        string Msg();
    }
    public class Greet : ITest
    {
        public string Msg()
        {
            string Name="Vaibhavraj";
            return "Hello" + Name;
        }
    }
}
