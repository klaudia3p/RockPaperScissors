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
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");

                while (true)
                {
                    Console.WriteLine("Please enter your move (rock, paper, or scissors):");
                    string playerMove = Console.ReadLine().ToLower();

                    if (playerMove != "rock" && playerMove != "paper" && playerMove != "scissors")
                    {
                        Console.WriteLine("Invalid move. Please try again.");
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

                    Console.WriteLine("Computer move: " + computerMove);

                    if (playerMove == computerMove)
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    else if (playerMove == "rock" && computerMove == "scissors" ||
                             playerMove == "paper" && computerMove == "rock" ||
                             playerMove == "scissors" && computerMove == "paper")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("Computer wins!");
                    }

                    Console.WriteLine("Do you want to play again? (yes or no)");
                    string playAgain = Console.ReadLine().ToLower();

                    if (playAgain != "yes")
                    {
                        break;
                    }
                }

                Console.WriteLine("Thanks for playing!");
                Console.ReadKey();
            }
        }
    }


    

