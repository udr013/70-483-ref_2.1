using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    //all values will always be initialized when a new structure gets created
    struct AlienStruct
    {
        public int X;
        public int Y;
        public int Lives;

        //constructor
        public AlienStruct(int x, int y)
        {
            X = x;
            Y = y;
            Lives = 3;
        }

        //override tostring
        public override string ToString()
        {
            return string.Format("X : {0}, Y: {1}, Lives: {2}", X, Y, Lives);
        }
    }

    class AlienClass
    {
        public int X;
        public int Y;
        public int Lives;

        //constructor
        public AlienClass(int x, int y)
        {
            X = x;
            Y = y;
            Lives = 3;
        }

        //override tostring
        public override string ToString()
        {
            return string.Format("X : {0}, Y: {1}, Lives: {2}", X, Y, Lives);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //constructed without new keyword and no constructor
            AlienStruct a;
            a.X = 50;
            a.Y = 50;
            a.Lives = 3;
            Console.WriteLine("a {0}", a.ToString());

            AlienStruct x = new AlienStruct(100, 100);
            Console.WriteLine("x {0}", x.ToString());

            AlienStruct[] swarm = new AlienStruct[20];
            Console.WriteLine("Swarm [3] {0}", swarm[3].ToString());

            AlienClass[] swarm2 = new AlienClass[3];
            Console.WriteLine("Swarm [3] {0}", swarm[3].ToString());
            Console.ReadKey();

            /// a X : 50, Y: 50, Lives: 3
            /// x X : 100, Y: 100, Lives: 3
            /// Swarm[3] X: 0, Y: 0, Lives: 0
        }
    }
}
