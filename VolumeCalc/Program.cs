using System;

namespace VolumeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables.
            double height;
            double width;
            double length;

            // Using ReadLine to accept input, and WriteLine to write in conosle.
            Console.WriteLine("This is a volume calculator.\nPlease enter the length, height and width.\n");
            Console.WriteLine("Enter the length:");
            while (true)  // Using a while loop to prevent an input that is not a double to crash the program.
                          // Originally, this was a try-catch with a FormatExecption, but this will suffice.
            {
                Console.Write("> ");
                if (double.TryParse(Console.ReadLine(), out length)) break;
                Console.WriteLine("Your input is invalid. Please try again.");
            }
            Console.WriteLine("Enter the height:");
            while (true)
            {
                Console.Write("> ");
                if (double.TryParse(Console.ReadLine(), out height)) break;
                Console.WriteLine("Your input is invalid. Please try again.");
            }
            Console.WriteLine("Enter the width:");
            while (true)
            {
                Console.Write("> ");
                if (double.TryParse(Console.ReadLine(), out width)) break;
                Console.WriteLine("Your input is invalid. Please try again.");
            }
            // Outputs the result by calcating them.
            Console.WriteLine("\nThe volume is " + (length * height * width)/* + "\u00b3"*/ + " cubic something.");
        }
    }
}