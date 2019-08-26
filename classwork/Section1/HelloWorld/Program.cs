using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
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
    }
}
