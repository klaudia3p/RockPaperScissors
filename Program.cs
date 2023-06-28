using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("\n\n\n\t\t\tWelcome to Rock, Paper, Scissors!");

                while (true)
                {
                    Console.WriteLine("\n\t\tPlease enter your move (rock, paper, or scissors):");
                string playerMove = Console.ReadLine().ToLower();


                if (playerMove != "rock" && playerMove != "paper" && playerMove != "scissors")
                    {
                        Console.WriteLine("\n\t\tInvalid move. Please try again.");
                        continue;
                    }

                    Random random = new Random();
                    string computerMove = "";
                    int computerMoveNumber = random.Next(1, 4);

                    if (computerMoveNumber == 1)
                    {
                        computerMove = "rock";
                    }
                    else if (computerMoveNumber == 2)
                    {
                        computerMove = "paper";
                    }
                    else if (computerMoveNumber == 3)
                    {
                        computerMove = "scissors";
                    }

                    Console.WriteLine("\n\t\t\tComputer move: " + computerMove);

                    if (playerMove == computerMove)
                    {
                        Console.WriteLine("\n\t\tIt's a tie!");
                    }
                    else if (playerMove == "rock" && computerMove == "scissors" ||
                             playerMove == "paper" && computerMove == "rock" ||
                             playerMove == "scissors" && computerMove == "paper")
                    {
                        Console.WriteLine("\n\t\tYou win!");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tComputer wins!");
                    }

                    Console.WriteLine("\n\t\tDo you want to play again? (yes or no)");
                    string playAgain = Console.ReadLine().ToLower();

                    if (playAgain != "yes")
                    {
                        break;
                    }
                }

                Console.WriteLine("\n\n\t\t\tThanks for playing!");
            Console.ReadKey();
            Console.ReadKey();
            }
        }
    }


    

