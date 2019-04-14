using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = @"A rocket explorer called Wright,
                        Once travelled much faster than light,
                        He set out one day,
                        In aa releative way,
                        And returned on the previous night";

            //using an extention method LineCount as if it is part of string class
            Console.WriteLine(text.LineCount());
            Console.ReadKey();
        }

    }
}
