using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            DisplayWelcome();

            // Get user's personal details
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            // Calculate the square of the favorite number
            int squaredNumber = SquareNumber(userNumber);

            // Output the final results to the console
            DisplayResult(userName, squaredNumber);
        }

        // 1. Displays the initial welcome greeting
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // 2. Prompts the user for their name and returns it as a string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // 3. Prompts the user for their favorite number and returns it as an integer
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        // 4. Accepts an integer, calculates its square, and returns the result
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // 5. Accepts the name and squared number, then displays the final summary message
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}
