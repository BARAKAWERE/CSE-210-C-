using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string playAgain = "yes";

            while (playAgain.ToLower() == "yes")
            {
                // Core Requirement 3:
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101);

                int guess = -1;
                int guessCount = 0; 

                // Core Requirement 2: 
                while (guess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    
                    // Core Requirement 1 & Sample Solution Logic
                    guess = int.Parse(Console.ReadLine());
                    guessCount++; // Inaongeza hesabu kila mtumiaji anapokisia

                    if (magicNumber > guess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (magicNumber < guess)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }

                
                Console.WriteLine($"It took you {guessCount} guesses.");
                
                // Kipengele cha ziada: Kuuliza kama anataka kucheza tena
                Console.Write("Do you want to play again (yes/no)? ");
                playAgain = Console.ReadLine();
                Console.WriteLine(); // Inaacha mstari wazi kwa ajili ya mchezo mpya
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}
