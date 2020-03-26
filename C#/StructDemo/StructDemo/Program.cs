using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    struct Books
    {
        private string author;
        private string subject;
        private int book_id;

        public string Title { get; set; }

        public void setValues(string t,string a, string s, int id)
        {
            Title = t;
            author = a;
            subject = s;
            book_id = id;       
        }
        public void display()
        {
            Console.WriteLine(Title);
            Console.WriteLine(author);
            Console.WriteLine(subject);
            Console.WriteLine(book_id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.Title="C Programming";
            book1.setValues("C", "Author 1", "C Programming Tutorial", 1);
            book1.Title = "C Programming";
            book2.setValues("Telecom Billing", "Author 2", "Telecom Billing Tutorial", 2);
            book1.display();
            book2.display();
            Console.ReadKey();
        }
    }
}
