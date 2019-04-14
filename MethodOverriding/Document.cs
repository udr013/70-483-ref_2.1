using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    class Document
    {
        public void GetDate()
        {
            Console.WriteLine("Hello from GetDate in Document");
        }

        public virtual void DoPrint()
        {
            Console.WriteLine("Hello for DoPrint in Document");
        }
    }
}
