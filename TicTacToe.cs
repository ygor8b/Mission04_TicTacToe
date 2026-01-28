using System;
using System.Collections.Generic;
using System.Text;

namespace Mission04_TicTacToe
{
    internal class TicTacToe
    {
        public void PrintBoard(char[] board) // Print the Tic Tac Toe board
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }

        public string IsWinner(char[] board) // Check for a winner or tie, or continue playing
        {
            string message = "";

            // Check if winner (player 1 is X, player 2 is O)
            if ((board[0] == 'X' && board[1] == 'X' && board[2] == 'X') ||
                (board[3] == 'X' && board[4] == 'X' && board[5] == 'X') ||
                (board[6] == 'X' && board[7] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[3] == 'X' && board[6] == 'X') ||
                (board[1] == 'X' && board[4] == 'X' && board[7] == 'X') ||
                (board[2] == 'X' && board[5] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[4] == 'X' && board[8] == 'X') ||
                (board[2] == 'X' && board[4] == 'X' && board[6] == 'X'))
            {
                message = "Player 1 wins!";
            }
            else if ((board[0] == 'O' && board[1] == 'O' && board[2] == 'O') ||
                     (board[3] == 'O' && board[4] == 'O' && board[5] == 'O') ||
                     (board[6] == 'O' && board[7] == 'O' && board[8] == 'O') ||
                     (board[0] == 'O' && board[3] == 'O' && board[6] == 'O') ||
                     (board[1] == 'O' && board[4] == 'O' && board[7] == 'O') ||
                     (board[2] == 'O' && board[5] == 'O' && board[8] == 'O') ||
                     (board[0] == 'O' && board[4] == 'O' && board[8] == 'O') ||
                     (board[2] == 'O' && board[4] == 'O' && board[6] == 'O'))
            {
                message = "Player 2 wins!";
            }
            // if no game winner, check if board is not default (tie)
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' &&
                     board[3] != '4' && board[4] != '5' && board[5] != '6' &&
                     board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                message = "It's a tie!";
            }
            // Otherwise, game continues
            else
            {
                message = "No winner yet, keep playing!";
            }

            return message;
        }
    }
}
