﻿using System;


namespace PaperRockScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerScore = new Player();
            Computer computerScore = new Computer();
            
            while (true)
            {
                Console.WriteLine("Welcome to Paper Rock Scissors");
                Console.WriteLine("Please select\n 1. Paper \n 2. Rock \n 3. Scissors");
                var userChoice = Services.UserInput(Console.ReadLine());
                var compChoice = Services.ComputerPick();

                Services.WhoWins(userChoice, compChoice);
                
                if (Services.PlayAgain()== false){
                    break;
                }
                

                
                Console.ReadLine();
            }
            
            
        }
        
    }
}
