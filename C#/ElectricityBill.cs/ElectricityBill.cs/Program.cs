using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill.cs
{
    class Program
    {
       
        Program()
        {
            Double unit;
            int choice;
            Double Dtotal, Ctotal;
            Console.WriteLine("\n\nWelcome To Electricity Department\n ");
            Console.WriteLine("Constructor Block Executed Successfully\n");
            Console.Write("Total Unit Consume By Customer :");
            unit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Type Of Customer\n");
            Console.WriteLine("press 1 For Domestic and 2 For Comercial:\t");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    {
                        if (unit >= 0 && unit <= 500)
                        {
                            Dtotal = unit * 0.75;
                            Console.WriteLine("Total Bill amount of Domestic Consumer=" + Dtotal);
                            
                        }
                        else if (unit >= 501 && unit <= 1000)
                        {
                            Dtotal = unit * 2.35;
                            Console.WriteLine("Total Bill amount of Domestic Consumer=" + Dtotal);
                        }
                        else if (unit >= 1001 && unit <= 1500)
                        {
                            Dtotal = unit * 3.05;
                            Console.WriteLine("Total Bill amount of Domestic Consumer=" + Dtotal);
                        }
                        else if (unit >= 1501 && unit <= 2000)
                        {
                            Dtotal = unit * 4.00;
                            Console.WriteLine("Total Bill amount of Domestic Consumer=" + Dtotal);
                        }
                        else if (unit >= 2001)
                        {
                            Dtotal = unit * 5.15;
                            Console.WriteLine("Total Bill amount of Domestic Consumer=" + Dtotal);
                        }
                    }
                    Console.ReadKey();
                    break;

                case 2:
                    {
                        if (unit >= 0 && unit <= 500)
                        {
                            Ctotal = unit * 0.9;
                            Console.WriteLine("Total Bill amount of Commercial Consumer=" + Ctotal);
                        }
                        else if (unit >= 501 && unit <= 1000)
                        {
                            Ctotal = unit * 2.82;
                            Console.WriteLine("Total Bill amount of Commercial Consumer=" + Ctotal);
                        }
                        else if (unit >= 1001 && unit <= 1500)
                        {
                            Ctotal = unit * 3.66;
                            Console.WriteLine("Total Bill amount of Commercial Consumer=" + Ctotal);
                        }
                        else if (unit >= 1501 && unit <= 2000)
                        {
                            Ctotal = unit * 4.8;
                            Console.WriteLine("Total Bill amount of Commercial Consumer=" + Ctotal);
                        }
                        else if (unit >= 2001)
                        {
                            Ctotal = unit * 6.18;
                            Console.WriteLine("Total Bill amount of Commercial Consumer=" + Ctotal);
                        }
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    {
                        Console.WriteLine("Invalid Choice");
                    }
                    Console.ReadKey();
                    break;
            }
        }
        ~Program ()
        {
            Console.WriteLine("Destroying code for constructor");
            Console.ReadKey();
        }
  
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.ReadKey();

        }
    }
    
}
