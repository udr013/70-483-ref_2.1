using System;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(636679008000000000);
            DateTime d2 = new DateTime(2018,7,23);
            DateTime d3 = new DateTime(year:2018,month:7,day:23);
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.ReadKey();
        }
    }
}
