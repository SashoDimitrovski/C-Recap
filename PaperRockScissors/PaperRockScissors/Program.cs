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
                Services.WhoWins(Services.UserInput(Console.ReadLine()), Services.ComputerPick());
                if (Services.PlayAgain()== false){
                    break;
                }
                

                
                Console.ReadLine();
            }
            
            
        }
        
    }
}
