using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.Maze
{
    class Rooms
    {
        enum Direction
        {
            North,
            East,
            South,
            West
        }
        enum Offset
        {
            Left = -1,
            Forward,
            Right,
            Around
        }
        public static void StartingRoom ()
        {
            //while (true)
            //{
            Commands.Command command = Commands.HandleCommand ();
            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and west.");
                    Room1 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north");
                    StartingRoom ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    StartingRoom ();
                    break;
                }
            }
        }

        public static void ExitRoom ()
        {
            Console.WriteLine ("You feel a slight breeze, and can see the light of day. You made it!\n" +
                "As you walk out, you see a number of angry orcs, all turned toward you.\n" +
                "Looks like the mystery deepens, and another adventure is about to begin.");
            Console.ReadKey ();
        }

        public static void Room1 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveLeft:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and east.");
                    Room12 ();
                    break;
                }
                case Commands.Command.MoveRight:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and west.");
                    Room2 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the east and west");
                    Room1 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room1 ();
                    break;
                }
            }
        }

        public static void Room2 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room3 ();
                    break;
                }
                case Commands.Command.MoveLeft:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and west.");
                    Room1 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north and south");
                    Room2 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room2 ();
                    break;
                }
            }

        }

        public static void Room3 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, south, and west.");
                    Room4 ();
                    break;
                }
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and west.");
                    Room2 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north and west.");
                    Room3 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room3 ();
                    break;
                }
            }
        }

        public static void Room4 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room5 ();
                    break;
                }
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room3 ();
                    break;
                }
                case Commands.Command.MoveLeft:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and west.");
                    Room13 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north, south, and west.");
                    Room4 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room4 ();
                    break;
                }
            }
        }

        public static void Room5 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the south and west.");
                    Room6 ();
                    break;
                }
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, south, and west.");
                    Room4 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north and south.");
                    Room5 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room5 ();
                    break;
                }
            }
        }

        public static void Room6 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room5 ();
                    break;
                }
                case Commands.Command.MoveLeft:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and west.");
                    Room7 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the south and west.");
                    Room6 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room6 ();
                    break;
                }
            }
        }

        public static void Room7 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    ExitRoom ();
                    break;
                }
                case Commands.Command.MoveLeft:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and south.");
                    Room8 ();
                    break;
                }
                case Commands.Command.MoveRight:
                {
                    Console.WriteLine ("You enter the room and spot doors to the south and west.");
                    Room6 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north, east, and west" +
                        " with some light coming from the northern room.");
                    Room7 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room7 ();
                    break;
                }
            }
        }

        public static void Room8 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room9 ();
                    break;
                }
                case Commands.Command.MoveRight:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, east, and west.");
                    Room7 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the east and south.");
                    Room8 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room8 ();
                    break;
                }
            }
        }

        public static void Room9 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and south.");
                    Room8 ();
                    break;
                }
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, east, and south.");
                    Room10 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north and south.");
                    Room9 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room9 ();
                    break;
                }
            }
        }

        public static void Room10 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room9 ();
                    break;
                }
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room11 ();
                    break;
                }
                case Commands.Command.MoveRight:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and west.");
                    Room13 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north, south, and east.");
                    Room10 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room10 ();
                    break;
                }
            }
        }

        public static void Room11 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, east, and south.");
                    Room10 ();
                    break;
                }
                case Commands.Command.MoveBackward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and east.");
                    Room12 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north and south.");
                    Room11 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room11 ();
                    break;
                }
            }
        }

        public static void Room12 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveForward:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north and south.");
                    Room11 ();
                    break;
                }
                case Commands.Command.MoveRight:
                {
                    Console.WriteLine ("You enter the room and spot doors to the east and west.");
                    Room1 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the north and east.");
                    Room12 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room12 ();
                    break;
                }
            }
        }

        public static void Room13 ()
        {
            Commands.Command command = Commands.HandleCommand ();

            switch (command)
            {
                case Commands.Command.MoveRight:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, south, and west.");
                    Room4 ();
                    break;
                }
                case Commands.Command.MoveLeft:
                {
                    Console.WriteLine ("You enter the room and spot doors to the north, south, and east.");
                    Room10 ();
                    break;
                }
                case Commands.Command.Look:
                {
                    Console.Out.WriteLine ("There's a door to the east and west.");
                    Room13 ();
                    break;
                }
                case Commands.Command.Quit:
                {
                    break;
                }
                default:
                {
                    Console.Out.WriteLine ("I can't do that now.");
                    Room13 ();
                    break;
                }
            }
        }
    }
}
