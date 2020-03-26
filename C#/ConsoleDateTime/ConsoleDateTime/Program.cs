using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var date01 = new DateTime(2020, 5, 1,8,30,52);
            Console.WriteLine(date01);

            var date02 = DateTime.Now;
            Console.WriteLine("Now");
            Console.WriteLine(date02);

            var date03 = DateTime.UtcNow;
            Console.WriteLine("UtcNow");
            Console.WriteLine(date03);

            var date04 = DateTime.Today;
            Console.WriteLine("Today");
            Console.WriteLine(date04);

            Console.WriteLine("DayOfWeek");
            Console.WriteLine(date04.DayOfWeek);

            Console.WriteLine("DayOfYear");
            Console.WriteLine(date04.DayOfYear);

            var tomorrow = date02.AddDays(1);
            Console.WriteLine("Tomorrow");
            Console.WriteLine(tomorrow);

            Console.WriteLine("ToShortDateString");
            Console.WriteLine(date02.ToShortDateString());
            Console.WriteLine("ToLongDateString");
            Console.WriteLine(date02.ToLongDateString());
            Console.WriteLine("ToLongTimeString");
            Console.WriteLine(date02.ToLongTimeString());
            Console.WriteLine("ToShortTimeString");
            Console.WriteLine(date02.ToShortTimeString());

            Console.WriteLine("Tostring()");
            Console.WriteLine(date02.ToString());
            Console.WriteLine("yy-MM-dd");
            Console.WriteLine(date02.ToString("yy-MM-dd"));
            Console.WriteLine("yy-MMM-dd");
            Console.WriteLine(date02.ToString("yy-MMM-dd"));

            var birthday = DateTime.Parse("08/05/1997");
            TimeSpan age = DateTime.Now.Subtract(birthday);
            Console.WriteLine(age.TotalDays);
            Console.ReadKey();
        }
    }
}
