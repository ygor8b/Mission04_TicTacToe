using System;
using System.Collections.Generic;

namespace  Mission04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                Console.WriteLine("\n=== Welcome to Ygor's Tic Tac Toe ===");
                Console.WriteLine("1) Multi Player");
                Console.WriteLine("2) Exit");
                Console.WriteLine("\n Choose an option (1-2): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        board = new char[3, 3];
                        MultiPlayer(board);
                        break;

                    case "2":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter 1, 2, 3, or 4.");
                        break;

                }

            }
        }
    }
}