//-----------------------------------------------------------------------
// <copyright file="TicTocToe.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used for implementing tic toc toe game
    /// </summary>
    public class TicTocToe
    {
        /// <summary>
        /// game array is used to store the values that are given by the player and computer
        /// </summary>
        private char[,] game = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

        /// <summary>
        /// count is used to number of positions is filled in game array
        /// </summary>
        private int count = 0;

        /// <summary>
        /// player symbol is used to assign a symbol for the player
        /// </summary>
       private char playerSymbol = 'X';

        /// <summary>
        /// computer symbol is used to assign a symbol to the computer
        /// </summary>
        private char computerSymbol = 'O';

        /// <summary>
        /// this class is used for generating random values
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// end game is used to break the while condition when someone will win
        /// </summary>
        private bool endGame;

        /// <summary>
        /// Tic Toc Toe Game method is used for starting the game
        /// </summary>
        public void TicTocToeGame()
        {
            while (this.count < 9)
            {
               this.Computer();
                Console.WriteLine("---------computer selected-----------------");
                this.DisplayGame();
                 this.endGame = this.Winner();
                if (this.endGame == true)
                {
                    Console.WriteLine("############### game completed ################");
                    break;
                }

               this.Player();
                Console.WriteLine("---------player selected-----------------");
                this.DisplayGame();
                 this.endGame = this.Winner();
                if (this.endGame == true)
                {
                    Console.WriteLine("############### game completed ################");
                    break;
                }
            }
        }

        /// <summary>
        /// this method is used for playing the computer
        /// </summary>
        public void Computer()
        {
             int row = this.random.Next(3);
             int column = this.random.Next(3);
            if (this.game[row, column] == '-')
            {
                this.game[row, column] = this.computerSymbol;
                this.count++;
                return;
            }
            else
            {
                this.Computer();
            }
        }

        /// <summary>
        /// this method is used to playing the player
        /// </summary>
        public void Player()
        {
            Console.WriteLine("enter row value");
            int row = Utility.GetInt();
            Console.WriteLine("enter coloumn value");
             int column = Utility.GetInt();
            if (row > 0 && column > 0 && row <= 2 && column <= 2)
            {
                if (this.game[row, column] == '-')
                {
                    this.game[row, column] = this.playerSymbol;
                    this.count++;
                    return;
                }
                else
                {
                    Console.WriteLine("enter proper row and coloumn value");
                    this.Player();
                }
            }
            else
            {
                Console.WriteLine("enter proper row and column");
                this.Player();
            }
        }

        /// <summary>
        /// this method is used to display the values that are placed by the computer and player
        /// </summary>
        public void DisplayGame()
        {
            Console.WriteLine("==============================");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(this.game[i, j] + "  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("==============================");
        }

        /// <summary>
        /// this method is used to know who id the winner
        /// </summary>
        /// <returns> it returns the boolean value to stop the game</returns>
        public bool Winner()
        {
            if ((this.game[0, 0] == 'X' && this.game[0, 1] == 'X' && this.game[0, 2] == 'X') ||
               (this.game[1, 0] == 'X' && this.game[1, 1] == 'X' && this.game[1, 2] == 'X') ||
               (this.game[2, 0] == 'X' && this.game[2, 1] == 'X' && this.game[2, 2] == 'X') ||
               (this.game[0, 0] == 'X' && this.game[1, 1] == 'X' && this.game[2, 2] == 'X') ||
               (this.game[0, 2] == 'X' && this.game[1, 1] == 'X' && this.game[2, 0] == 'X'))
            {
                Console.WriteLine("****************PLAYER WIN*********************");
                this.DisplayGame();
                return true;
            }
            else if ((this.game[0, 0] == 'O' && this.game[0, 1] == 'O' && this.game[0, 2] == 'O') ||
               (this.game[1, 0] == 'O' && this.game[1, 1] == 'O' && this.game[1, 2] == 'O') ||
               (this.game[2, 0] == 'O' && this.game[2, 1] == 'O' && this.game[2, 2] == 'O') ||
               (this.game[0, 0] == 'O' && this.game[1, 1] == 'O' && this.game[2, 2] == 'O') ||
               (this.game[0, 2] == 'X' && this.game[1, 1] == 'X' && this.game[2, 0] == 'X'))
            {
                Console.WriteLine("****************COMPUTER WIN*********************");
                this.DisplayGame();
                return true;
            }
            else if (this.count == 9)
            {
                Console.WriteLine("****************DRAW GAME*********************");
                this.DisplayGame();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
