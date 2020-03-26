using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningMembersinClass
{
    class Student
    {
        int StudentID;
        string StudentName;

        public int SID
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }
        public string SName
        {
            get
            {
                return StudentName;
            }
            set
            {
                StudentName = value;
            }
        }
        public void printDetails()
        {
            Console.WriteLine("Student Id:" + StudentID +"\n"+"Student Name:" + SName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new DefiningMembersinClass.Student();
       
            Console.Write("Student ID :");
            student.SID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name :");
            student.SName = Console.ReadLine();

            student.printDetails();
            Console.ReadKey();
        }
    }
}
