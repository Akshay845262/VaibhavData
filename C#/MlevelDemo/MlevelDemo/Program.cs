using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlevelDemo
{
    class Person
        {
            string name, gender;
            int age;
            public
            void getdata()
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gender: ");
                gender = Console.ReadLine();
            }
            public void display()
            {
                Console.WriteLine("Name: " + name + "\n");
                Console.WriteLine("Age: " + age + "\n");
                Console.WriteLine("Gender: " + gender + "\n");
            }
        };
        class employee : Person
        {
            string company;
            float  salary;
            public
                void getdata()
            {
                base.getdata();
                Console.WriteLine("Name of Company: ");

                company = Console.ReadLine();
                Console.WriteLine("Salary: Rs.");
                salary = float.Parse(Console.ReadLine());
            }
            public void display()
            {
                base.display();
                Console.WriteLine("Name of Company: " + company + "\n");
                Console.WriteLine("Salary: Rs." + salary + "\n");
            }
        };
        class programmer : employee
        {
            int number;
            public
                void getdata()
            {
                base.getdata();
                Console.WriteLine("Number of programming language known: ");
                number = Convert.ToInt32(Console.ReadLine());

            }
            public void display()
            {
                base.display();
                Console.WriteLine("Number of programming language known: " + number);
            }
        };
        
    

    class Program
    {
        static void Main(string[] args)
        {
            programmer p = new programmer();
            Console.WriteLine("Enter data\n");
            p.getdata();
            Console.WriteLine("\nDisplaying Data\n");
            p.display();
            Console.ReadKey();
        }
    }
}
