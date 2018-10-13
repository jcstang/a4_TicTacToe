using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a4_TicTacToe
{
    public partial class Form1 : Form
    {
        clsTicTacToe clsTicTac;
        bool bIsGameStarted;
        string[,] saBoard;

        public Form1()
        {
            InitializeComponent();
            saBoard = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    saBoard[i, j] = "Y";
                }
            }
            clsTicTac = new clsTicTacToe();
            clsTicTac.saBoard = saBoard;
            bIsGameStarted = false;
        }

        #region button clicks
        private void start_Click(object sender, EventArgs e)
        {
            //Need to start the game or set bIsGameStarted variable
            bIsGameStarted = true;
            ClearLabels();
            ResetColors();
        }

        private void Space_Click(object sender, EventArgs e)
        {
            //1. bIsGameStarted
            //2. is space blank
            //3. LoadBoard()
            //4. clsTicTac.IsWinningMove()
            //5. HighlightWinningMove() and DisplayScores()
            //6. clsTicTac.IsTie()
            //7. DisplayScores() [game over]
            Label myLabel = (Label)sender;

            if (bIsGameStarted && myLabel.Text == " ")
            {
                LoadBoard();
                //TODO: change the player and the text
                //if IsWinningMove
                HighlightWinningMove();

                //if IsTie()
                // handle tie?

                DisplayScores();
            }

            //** example program **
            //cast the sender to label
            //label myLabel = (Label)sender;
            //mylabel.text = "x";
            //setBackgroundColor(myLabel);
        }


        #endregion


        //TODO: LoadBoard()
        private void DisplayScores()
        {
            //DisplayScores on the board
        }
        private void HighlightWinningMove()
        {
            //set color of the winning move color`
        }
        private void ClearLabels()
        {
            //change the text of the labels
            lblTopLeft.Text = " ";
            lblTopMid.Text = " ";
            lblTopRight.Text = " ";

            lblMidLeft.Text = " ";
            lblMidMid.Text = " ";
            lblMidRight.Text = " ";

            lblBotLeft.Text = " ";
            lblBotMid.Text = " ";
            lblBotRight.Text = " ";

        }
        private void ResetColors()
        {
            Color resetColor = Color.White;

            SetBackgroundColor(lblTopLeft, resetColor);
            SetBackgroundColor(lblTopMid, resetColor);
            SetBackgroundColor(lblTopRight, resetColor);

            SetBackgroundColor(lblMidLeft, resetColor);
            SetBackgroundColor(lblMidMid, resetColor);
            SetBackgroundColor(lblMidRight, resetColor);

            SetBackgroundColor(lblBotLeft, resetColor);
            SetBackgroundColor(lblBotMid, resetColor);
            SetBackgroundColor(lblBotRight, resetColor);


        }
        private void LoadBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write( clsTicTac.saBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private void SetBackgroundColor(Label lblLabel, Color changeToColor)
        {
            //lblLabel.BackColor = Color.Yellow;
            lblLabel.BackColor = changeToColor;

        }

    }
}
