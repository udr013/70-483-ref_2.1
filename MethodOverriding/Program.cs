using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            Invoice invoice2 = new PrePaidInvoice();
            invoice.GetDate();
            invoice.DoPrint();
            invoice2.DoPrint();

            Console.ReadKey();
        }
    }
}
