using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum AlienState
    {
        Sleeping,
        Attacking,
        Destroyed
    };

    enum AlienState2 : byte
    {
        Sleeping,
        Attacking,
        Destroyed
    };

    enum AlienState3 : byte
    {
        Sleeping = 4,
        Attacking = 5,
        Destroyed = 6
    };

    class Programn
    {
        static void Main(string[] args)
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine(x);

            AlienState2 y = AlienState2.Attacking;
            Console.WriteLine((byte) y);

            AlienState3 z = AlienState3.Attacking;
            Console.WriteLine((byte) z);

            Console.ReadKey();
        }
    }
}

