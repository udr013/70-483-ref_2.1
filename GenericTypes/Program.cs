using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Program
    {
        /// <summary>
        /// we can use Generic constrains (see page 105) like:
        /// class MyStack<T> where T:class
        /// class MyStack<T> where T:struct
        /// class MyStack<T> where T:new()
        /// class MyStack<T> where T:class
        /// class MyStack<T> where T:<base class>
        /// class MyStack<T> where T:<interface>
        /// class MyStack<T> where T:unmanaged
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class MyStack<T> where T:class
        {
            int stackTop = 0;
            T[] items = new T[5];


            public void Push(T item)
            {
                if (stackTop == items.Length)
                {
                    throw new Exception("Stack full");
                }

                items[stackTop] = item;
                stackTop++;
            }

            public T Pop()
            {
                if (stackTop == 0)
                {
                    throw new Exception("Stack empty");
                }

                stackTop--;
                return items[stackTop];

            }
        }

        static void Main(string[] args)
        {
            MyStack<string> namestack = new MyStack<string>();
            namestack.Push("Mark");
            namestack.Push("Kai");
            namestack.Push("Saskia");
            namestack.Push("Robin");
            namestack.Push("Liam");

           
            Console.WriteLine(namestack.Pop());
            Console.WriteLine(namestack.Pop());
            Console.WriteLine(namestack.Pop());

            Console.ReadKey();

        }
    }
}


