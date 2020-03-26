using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface G1
    {

        // method declaration 
        void mymethod();
    }

    interface G2
    {

        // method declaration 
        void mymethod();
    }

    class C : G1, G2
    {
        // Here mymethod belongs to  
        // G1 interface 
        void G1.mymethod()
        {
            Console.WriteLine("Vaibhav");
        }

        // Here mymethod belongs to  
        // G2 interface 
        void G2.mymethod()
        {
            Console.WriteLine("Sankpal");
        }
    }

    // Driver Class 
    public class C1
    {

        // Main Method 
        static public void Main()
        {

            // Creating object of C 
            // of G1 interface 
            G1 obj = new C();

            // calling G1 interface method 
            obj.mymethod();

            // Creating object of C 
            // of G2 interface 
            G2 ob = new C();

            // calling G2 interface method 
            ob.mymethod();
        }
    }
}
