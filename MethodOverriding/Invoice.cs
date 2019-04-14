using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    class Invoice:Document
    {
        public override void DoPrint()
        {
            Console.WriteLine("Hello for DoPrint in Invoice");
        }
    }
}
