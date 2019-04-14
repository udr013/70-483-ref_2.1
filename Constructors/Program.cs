using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Alien
    {
        public static int Max_Lives = 99;
        public int X;
        public int Y;
        public int Lives;

        //public Alien(int x, int y)
        //{
        //    if(x < 0 || y < 0)
        //    {
        //        throw new ArgumentOutOfRangeException("invalid position");
        //    }
        //    X = x;
        //    Y = y;
        //    Lives = 3;
        //}
        
            /// we could simply replace the above with
        public Alien(int x, int y) : this(x, y, 3)
        {

        }

        public Alien(int x, int y, int lives)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentOutOfRangeException("invalid position");
            }

            if(lives > Max_Lives){
                throw new Exception("invalid lives exceding, Max_Lives");
            }

            X = x;
            Y = y;
            Lives = 3;
        }

        public bool RemoveLives(int LivesToRemove)
        {
            Lives = Lives - LivesToRemove;

            if (Lives <= 0)
            {
                X = -1000;
                Y = -1000;
                return false;
            }
            else{
                return true;
            }
        }

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lives: {2}", X, Y, Lives);
        }

        public static void Main(String[] args)
        {
            //because of named parameters we can switch the order...
            Alien x = new Alien(y:100, x:100);
            Console.WriteLine("x {0}", x);
            if (x.RemoveLives(2))
            {
                Console.WriteLine("Still alive");
            }
            else
            {
                Console.WriteLine("Alien destroyed");
            }

            Console.WriteLine("x {0}", x);
            Console.ReadKey();
        
        }

    }
}
