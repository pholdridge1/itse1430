using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            // Movie data
            // string title;
            // int runLength;
            // int releaseYear;
            // string description;
            // bool haveSeen;

            var quit = false;
            while(!quit)
            {
                char input = DisplayMenu();
                switch (input)
                {
                    // Fallthrough allowed only if case is empty
                    case 'a':
                    case 'A': AddMovie (); break;

                    // Must have break/return at end of each case
                    case 'D': DisplayMovie (); break;
                    case 'R': RemoveMovie (); break;
                    case 'Q':
                    {
                        quit = true;
                        break;
                    }

                    default: Console.WriteLine ("Not supported"); break;
                };

                //if (input == 'A')
                //    AddMovie ();
                //else if (input == 'D')
                //    DisplayMovie ();
                //else if (input == 'R')
                //    RemoveMovie ();
                //else if (input == 'Q')
                //    break;
            };          
        }

        private static void RemoveMovie ()
        {
            // Confirm removal
            if (!ReadBoolean ($"Are you sure you want to remove {title}?"))
                return;

            // Remove movie
            title = null;
        }

        static void AddMovie()
        {
            // Get title
            Console.Write("Title: ");
            title = Console.ReadLine ();

            // Get description
            Console.Write ("Description: ");
            description = Console.ReadLine ();

            // Get release year
            releaseYear = ReadInt32("Release Year: ");

            // Get run length
            runLength = ReadInt32("Run Length (in minutes): ");

            // Get have seen
            haveSeen = ReadBoolean("Have Seen? ");
        }

        static void DisplayMovie()
        {
            if(String.IsNullOrEmpty(title))
            {
                Console.WriteLine ("No movies");
                return;
            };

            // Title, description, release year, run length, haveSeen
            Console.WriteLine (title);
            Console.WriteLine (description);

            // Formatting strings
            // 1) String concat
            Console.WriteLine ("Released " + releaseYear);

            // 2) Printf
            // Console.WriteLine ("Run time: {0}", runLength);

            // 3) String formatting
            var formattedString = String.Format("Run time: {0}", runLength);
            Console.WriteLine (formattedString);

            // 4) String interpolation
            Console.WriteLine ($"Seen it? {haveSeen}");

            // Seperate movies
            Console.WriteLine ("".PadLeft (50, '-'));
        }

        static int ReadInt32 (string message)
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                // int result = Int32.Parse (input);
                if (Int32.TryParse (input, out int result))
                    return result;

                Console.WriteLine ("Not a number");
            };
        }

        static bool ReadBoolean( string message )
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                // int result = Int32.Parse (input);
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean");
            };
        }

        static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("(A)dd Movie");
                Console.WriteLine("(D)isplay Movie");
                Console.WriteLine("(R)emove Movie");
                Console.WriteLine("(Q)uit");

                string input = Console.ReadLine ();

                // Lower case
                input = input.ToLower();

                if (String.Compare (input, "a") == 0)
                {
                    return 'A';
                } else if (input == "q")
                {
                    return 'Q';
                } else if (input == "d")
                {
                    return 'D';
                } else if (input == "r")
                {
                    return 'R';
                } else
                {
                    Console.WriteLine ("Invalid input");
                }

            } while(true);
        }
        private static void DemoLanguage ()
        {
            string name = "";

            // Definitely assigned
            // name = "Bob";
            string name2 = name;
            name2 = Console.ReadLine ();
            Console.WriteLine (name2);

            Console.WriteLine ("Hello World!");

            // Another block
            // Yet another block

            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;

            string fullName = "Fred " + " " + "Jones";

            

        }
        static void DemoArray ()
        {
            double[] payRates = new double[100];

            // 50th element to 7.25
            payRates[49] = 7.25;

            // Read 89th element into temp variable;
            double payRate = payRates[88];

            // Print out the 80th element
            Console.WriteLine(payRates[79]);

            // An empty array
            bool[] isPassing = new bool[0];

            // Enumerating an array
            for(int i = 0; i < payRates.Length; ++i)
               Console.WriteLine (payRates[i]);

            string name = "Bob William Smith Jr III";

            string[] nameParts = name.Split(' ');
         }

        static void DemoString()
        {
            string str = null;

            // Checking for null or empty string
            if(str != null && str != "")
                str = str.ToLower();

            //Length - NO
            if (str != null && str.Length == 0)
                str = str.ToLower ();

            //Empty - NO
            if (str != null && str != String.Empty)
                str = str.ToLower ();

            //Correct approach
            if (!String.IsNullOrEmpty (str))
                str = str.ToLower ();
        }
        //Don't do this outside lab 1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool haveSeen;
    }
}

