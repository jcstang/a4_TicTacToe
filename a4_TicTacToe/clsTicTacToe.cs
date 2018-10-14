using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a4_TicTacToe
{
    /// <summary>
    /// TicTacToe Class - Houses the business logic for the project.
    /// </summary>
    class clsTicTacToe
    {
        public string[,] saBoard;
        private int iPlayer1Wins;
        private int iPlayer2Wins;
        private int iTies;
        private WinningMove eWinningMove;
        public Player eWhoseTurn;

        /// <summary>
        /// Constructor for tictactoe class.
        /// </summary>
        public clsTicTacToe()
        {
            saBoard = new string[3, 3];
            iPlayer1Wins = 0;
            iPlayer2Wins = 0;
            iTies = 0;
            eWhoseTurn = Player.player1;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="saGameBoard">passing a gameboard in</param>
        public clsTicTacToe(string[,] saGameBoard)
        {
            saBoard = saGameBoard;
            iPlayer1Wins = 0;
            iPlayer2Wins = 0;
            iTies = 0;
            eWhoseTurn = Player.player1;
        }

        /// <summary>
        /// Enum to keep track of player1 v player2
        /// </summary>
        public enum Player
        {
            player1,
            player2
        }
        /// <summary>
        /// Enum that deals with row,col, and diag verbage. 
        /// </summary>
        private enum WinningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
        }

        /// <summary>
        /// Changes the player 
        /// </summary>
        public void ChangePlayer()
        {
            if (eWhoseTurn == Player.player1)
            {
                eWhoseTurn = Player.player2;

            } else if(eWhoseTurn == Player.player2)
            {
                eWhoseTurn = Player.player1;
            }
        }


        /// <summary>
        /// is that the winning move
        /// </summary>
        /// <returns></returns>
        public bool IsWinningMove()
        {
            eWinningMove = WinningMove.Row2;

            return false;
        }
        /// <summary>
        /// Is this a diagonal win?
        /// </summary>
        /// <returns>bool</returns>
        private bool IsDiagonalWin()
        {
            return false;
        }
        /// <summary>
        /// Is this a vertical win?
        /// </summary>
        /// <returns>bool</returns>
        private bool IsVertWin()
        {
            return false;
        }
        /// <summary>
        /// Is this a horizontal win?
        /// </summary>
        /// <returns>bool</returns>
        private bool IsHorzWin()
        {
            return true;
        }
        /// <summary>
        /// did the game result in a tie?
        /// </summary>
        /// <returns>bool</returns>
        public bool IsTie()
        {
            return false;
        }

    }
}
