using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.Maze
{
    class Commands
    {
        public enum Command
        {
            Quit = 1,
            MoveForward,
            MoveBackward,
            MoveLeft,
            MoveRight,
            TurnLeft,
            TurnRight,
            TurnAround,
            Look
        }

        public static Command ParseCommand ( string input )
        {

            Enum.TryParse (input.Trim ().Replace (" ", String.Empty).ToLower (), true, out Command command);
            return command;
        }

        public static Command GetCommand ()
        {
            Console.WriteLine ("What do you want to do?");

            // Get input from user
            string input = Console.ReadLine ();
            Command command = ParseCommand (input);

            return command;
        }

        public static Command HandleCommand ()
        {
            Command command = GetCommand ();

            switch (command)
            {
                case Command.Quit:
                {
                    Console.WriteLine ("Are you sure you want to quit?");
                    char quitChar = Console.ReadLine ()[0];
                    if (quitChar == 'Y' || quitChar == 'y')
                    {
                        Console.Write ("Test");
                        return command;
                    } else
                    {
                        return HandleCommand ();
                    }

                }

                case Command.MoveForward:
                return command;
                case Command.MoveBackward:
                return command;
                case Command.MoveLeft:
                return command;
                case Command.MoveRight:
                return command;
                case Command.TurnRight:
                return command;
                case Command.TurnLeft:
                return command;
                case Command.TurnAround:
                return command;
                case Command.Look:
                return command;
                default:
                Console.WriteLine ("Maybe I should do something else. (Invalid Command)");
                return command = GetCommand ();
            }
        }
    }
}
