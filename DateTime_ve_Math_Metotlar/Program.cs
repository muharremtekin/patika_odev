using System;

namespace DateTime_ve_Math_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Month);

            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine(DateTime.Now.AddDays(20));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(50));
            Console.WriteLine(DateTime.Now.AddMonths(15));
            Console.WriteLine(DateTime.Now.AddYears(20));
            Console.WriteLine(DateTime.Now.AddMilliseconds(40));

            //DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));

            // MATH Kütüphanesi

            Console.WriteLine(Math.Abs(-22)); // 20
            Console.WriteLine(Math.Sin(20));
            Console.WriteLine(Math.Cos(20));
            Console.WriteLine(Math.Tan(20));

            Console.WriteLine(Math.Ceiling(22.4)); //23
            Console.WriteLine(Math.Round(22.4)); //22
            Console.WriteLine(Math.Round(22.6)); //23
            Console.WriteLine(Math.Floor(22.8)); //22
        }
    }
}
