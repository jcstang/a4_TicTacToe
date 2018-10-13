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
        List<Label> lListOfLabels;

        public Form1()
        {
            InitializeComponent();
            LoadLabels();
            saBoard = new string[3, 3];
            clsTicTac = new clsTicTacToe(saBoard);
            clsTicTac.saBoard = saBoard;
            bIsGameStarted = false;
        }

        private void LoadLabels()
        {
            lListOfLabels = new List<Label>();
            lListOfLabels.Add(lblTopLeft);
            lListOfLabels.Add(lblTopMid);
            lListOfLabels.Add(lblTopRight);

            lListOfLabels.Add(lblMidLeft);
            lListOfLabels.Add(lblMidMid);
            lListOfLabels.Add(lblMidRight);

            lListOfLabels.Add(lblBotLeft);
            lListOfLabels.Add(lblBotMid);
            lListOfLabels.Add(lblBotRight);

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
            //1. bIsGameStarted - done
            //2. is space blank - done
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
            for (int i = 0; i < clsTicTac.saBoard.Length; i++)
            {
                for (int j = 0; j < clsTicTac.saBoard.Length; j++)
                {
                    clsTicTac.saBoard[i,j]
                     
                }
            }
        }
        private void SetBackgroundColor(Label lblLabel, Color changeToColor)
        {
            //lblLabel.BackColor = Color.Yellow;
            lblLabel.BackColor = changeToColor;

        }

    }
}
