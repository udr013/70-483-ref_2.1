using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    class PrePaidInvoice: Invoice
    {
        public override void DoPrint()
        {
            base.DoPrint();
            Console.WriteLine("Hello from PrepaidInvoice");
        }
    }
}
