using System;

namespace NamedIntArray
{
    class NamedIntArray
    {
        
        private int[] array = new int[100];

        //Declare  an indexer property
        public int this[string name]
        {
            get
            {
                switch (name)
                {
                    case "zero":
                        return array[0];
                    case "one":
                        return array[1];
                    default:
                        return -1;
                }
            }

            set
            {
                switch (name)
                {
                    case "zero":
                       array[0] = value;
                        break;
                    case "one":
                        array[1] = value;
                        break;
                }
            }
        }

        public void setValue(int index, int value)
        {
            array[index] = value;
        }

        static void Main(string[] args)
        {
            NamedIntArray x = new NamedIntArray();
            x["zero"] = 99;
            x.setValue(1, 2);
            Console.WriteLine(x["zero"]);
            Console.WriteLine(x["one"]);
            Console.ReadKey();
        }
    }
}
