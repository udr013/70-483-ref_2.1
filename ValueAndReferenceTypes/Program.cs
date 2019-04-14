using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        // a struct is a value type, so x and y are different values
        struct StructStore
        {
            public int Data { get; set; }
        }

        //reference type, a and b refer to the same object
        class ClassStore 
        {
            public int Data { get; set; }
        }

        static void Main(string[] args)
        {
            StructStore x, y;
            y = new StructStore();
            y.Data = 4;
            x = y;
            x.Data = 100;

            Console.WriteLine("y = {0}", y.Data);
            Console.WriteLine("x = {0}", x.Data);

            ClassStore a, b;
            a = new ClassStore();
            a.Data = 3;
            b = a;
            a.Data = 12;

            Console.WriteLine("a = {0}", a.Data);
            Console.WriteLine("b = {0}", b.Data);

            Console.ReadKey();

        }
    }
}
