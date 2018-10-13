using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a4_TicTacToe
{
    class clsTicTacToe
    {
        public string[,] saBoard;
        private int iPlayer1Wins;
        private int iPlayer2Wins;
        private int iTies;
        private WinningMove eWinningMove;

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

        public bool IsWinningMove()
        {
            eWinningMove = WinningMove.Row2;

            return false;
        }
        private bool IsDiagonalWin()
        {
            return false;
        }
        private bool IsVertWin()
        {
            return false;
        }
        private bool IsHorzWin()
        {
            return true;
        }
        public bool IsTie()
        {
            return false;
        }

    }
}
