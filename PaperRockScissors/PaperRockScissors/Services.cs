using System;
using System.Collections.Generic;
using System.Text;

namespace PaperRockScissors
{
    public class Services
    {
        

        public static int UserInput(string input)
        {
            int number;
            number = int.Parse(input);

            try
            {
                if(number == 1 || number == 2 || number == 3)
                {
                    if(number == 1)
                    {
                        Console.WriteLine($"The Player chose {PRS.Paper}");
                    }
                    if (number == 2)
                    {
                        Console.WriteLine($"The Player chose {PRS.Rock}");
                    }
                    if (number == 3)
                    {
                        Console.WriteLine($"The Player chose {PRS.Scissors}");
                    }

                    return number;
                }
                else
                {
                    throw new Exception("You must select 1, 2 or 3");
                }
            }  catch (Exception ex)
            {
                Console.WriteLine("You must select 1, 2 or 3");
            }
            return number;
            
            
        }
        public static int ComputerPick()
        {
            Random random = new Random();
            int randomNo = random.Next(1, 3);
            if (randomNo == 1)
            {
                Console.WriteLine($"The Computer chose {PRS.Paper}");
            }
            if (randomNo == 2)
            {
                Console.WriteLine($"The Computer chose {PRS.Rock}");
            }
            if (randomNo == 3)
            {
                Console.WriteLine($"The Computer chose {PRS.Scissors}");
            }
            return randomNo;
        }
        public static void WhoWins(int player, int computer, Player playerA, Computer playerB, Games numberOfGames, Draw draw, Percent prc)
        {
            
            if (player == 1 && computer == 2)
            {
                Console.WriteLine("Player wins!");
                playerA.PlayerScore += 1;
                numberOfGames.GamesNo += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo) * 100} % wins");
                //Console.WriteLine($"The Computer has {prc.Percentage =  (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");


            }
            else if (player == 1 && computer == 3)
            {
                Console.WriteLine("Computer wins!");
                playerB.ComputerScore += 1;
                numberOfGames.GamesNo += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo) * 100} % wins");
                //Console.WriteLine($"The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");
            }
            else if (player == 2 && computer == 3)
            {
                Console.WriteLine("Player wins!");
                playerA.PlayerScore += 1;
                numberOfGames.GamesNo += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo) * 100} % wins");
                //Console.WriteLine($"The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");
            }
            else if (player == 2 && computer == 1)
            {
                Console.WriteLine("Computer wins!");
                playerB.ComputerScore += 1;
                numberOfGames.GamesNo += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo) * 100} % wins");
                //Console.WriteLine($"The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");
            }
            else if (player == 3 && computer == 1)
            {
                Console.WriteLine("Player wins!");
                playerA.PlayerScore += 1;
                numberOfGames.GamesNo += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / (numberOfGames.GamesNo)) * 100} % wins");
                //Console.WriteLine($"The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");
            }
            else if (player == 3 && computer == 2)
            {
                Console.WriteLine("Computer wins!");
                playerB.ComputerScore += 1;
                numberOfGames.GamesNo += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo) * 100} % wins");
                //Console.WriteLine($"The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");
            }
            else if (player == 1 && computer == 1)
            {
                Console.WriteLine("Draw!");
                numberOfGames.GamesNo += 1;
                draw.DrawGames += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo ) * 100} % wins. The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");
                
            }
            else if (player == 2 && computer == 2)
            {
                Console.WriteLine("Draw!");
                numberOfGames.GamesNo += 1;
                draw.DrawGames += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo) * 100} % wins. The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");

            }
            else if (player == 3 && computer == 3)
            {
                Console.WriteLine("Draw!");
                numberOfGames.GamesNo += 1;
                draw.DrawGames += 1;
                //Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / numberOfGames.GamesNo ) * 100} % wins. The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins. Total draw games {draw.DrawGames}");

            }
            Console.WriteLine($"The score is Player - {playerA.PlayerScore} : Computer - {playerB.ComputerScore}");
            Console.WriteLine($"Total games played - {numberOfGames.GamesNo}");
            Console.WriteLine($"The player has {prc.Percentage = (playerA.PlayerScore / (numberOfGames.GamesNo)) * 100} % wins");
            Console.WriteLine($"The Computer has {prc.Percentage = (playerB.ComputerScore / numberOfGames.GamesNo) * 100} % wins");


        }
        
        public static bool PlayAgain()
        {
            while (true)
            {
                Console.WriteLine("Would you like to play again? Y/N");
                string yesNoInput = Console.ReadLine().ToLower();
                if (yesNoInput.ToLower() == "y") return true;
                if (yesNoInput.ToLower() == "n") return false;

            }

            

        }
    }
}
