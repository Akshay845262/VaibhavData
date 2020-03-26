using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleLibrary;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int choice;
            Console.WriteLine("------------------------Calculator------------------------------\n");
            Console.WriteLine("1.Addition\t2.Substraction\t3.Multiplication\t4.Division\n");
            Console.WriteLine("enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
            double number1, number2, result;
            Console.WriteLine("Enter Two nos:\n");
            number1 = Convert.ToDouble((Console.ReadLine()));

            number2 = Convert.ToDouble((Console.ReadLine()));
            result = calc.Addition(number1, number2);
            Console.WriteLine("Addition=" + result);
                    break;
                case 2:
            double number3, number4, result1;
            Console.WriteLine("Enter Two nos:\n");
            number3 = Convert.ToDouble((Console.ReadLine()));

            number4 = Convert.ToDouble((Console.ReadLine()));
            result1 = calc.Subtraction(number3, number4);
            Console.WriteLine("Substraction=" + result1);
                    break;
                case 3:
            double number5, number6, result2;
            Console.WriteLine("Enter Two nos:\n");
            number5 = Convert.ToDouble((Console.ReadLine()));

            number6 = Convert.ToDouble((Console.ReadLine()));
            result2 = calc.Multiplication(number5, number6);
            Console.WriteLine("Multiplication=" + result2);
                    break;
                case 4:
            double number7, number8, result3;
            Console.WriteLine("Enter Two nos:\n");
            number7 = Convert.ToDouble((Console.ReadLine()));

            number8 = Convert.ToDouble((Console.ReadLine()));
            result3 = calc.Division(number7, number8);
            Console.WriteLine("Division=" + result3);
                    break;
                default:
                    Console.WriteLine("Please enter valid choice..");
                    break;
              
            }
            Greet g = new Greet();
            string output;

           
            output = g.Msg();
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
