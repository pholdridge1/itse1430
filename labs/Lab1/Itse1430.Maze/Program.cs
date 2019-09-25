using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.Maze
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.WriteLine ("You wake up in a room, dimly lit by a torch, " +
                 "unsure of where you are.\nYou take the torch off the wall.");

            Rooms.StartingRoom ();
        }
    }
}
