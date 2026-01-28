using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace  Mission04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ttt = new TicTacToe();
// Supporting Class
// Receive the “board” array from the driver class
// Contain a method that prints the board based on the information passed to it
// public void printBoard(int[] board)

// Contain a method that receives the game board array as input and returns if there is a
// winner and who it was
// public string isWinner(char[] board)

            while (true) 
            {
                // Welcome the user to the game 
                Console.WriteLine("\n=== Welcome to Tic Tac Toe ===");
                Console.WriteLine("1) Multi Player");
                Console.WriteLine("2) Exit");
                Console.WriteLine("\n Choose an option (1-2): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        // Create a game board array to store the players’ choices
                        char[] game_board = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
                        int playerChoice = 0;
                        char playerUp = 'X';
                        string gameStatus = "No winner yet, keep playing!";
                        
                        ttt.PrintBoard(game_board);

                        while (gameStatus == "No winner yet, keep playing!")
                        {
                            // Ask each player in turn for their choice and update the game board array
                            Console.WriteLine($"Player {playerUp}, Make your selection");

                            try
                            {
                                string selection = Console.ReadLine();
                                playerChoice = int.Parse(selection);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Please enter 1, 2, 3, or 4.");
                                continue;
                            }

                            try
                            {
                                if (game_board[(playerChoice - 1)] != 'X' && game_board[(playerChoice - 1)] != 'O')
                                {
                                    game_board[(playerChoice - 1)] = playerUp;

                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("That spot is already taken.");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Please enter 1, 2, 3, or 4.");
                                continue;
                            }


                            // Print the board by calling the method in the supporting class
                            Console.WriteLine();
                            ttt.PrintBoard(game_board);
                            // Check for a winner by calling the method in the supporting class, and notify the players
                            // when a win has occurred and which player won the game
                            gameStatus = ttt.IsWinner(game_board);
                            Console.WriteLine(gameStatus);
                            
                            if (playerUp == 'X')
                            {
                                playerUp = 'O';
                            }else
                            {
                                playerUp = 'X';
                            };
                        }

                        break;

                    case "2":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                        break;
                }

                

            }
        }
    }
}