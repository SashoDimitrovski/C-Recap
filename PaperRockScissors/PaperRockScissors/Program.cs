using System;


namespace PaperRockScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            
            while (true)
            {
                Console.WriteLine("Welcome to Paper Rock Scissors");
                Console.WriteLine("Please select\n 1. Paper \n 2. Rock \n 3. Scissors");
                Services.UserInput(Console.ReadLine());
                Services.ComputerPick();
                Services.PlayAgain();
                Services.WhoWins();
                Console.Clear();
                Console.ReadLine();
            }
            
            
        }
        
    }
}
