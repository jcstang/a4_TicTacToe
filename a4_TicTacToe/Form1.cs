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
    /// <summary>
    /// Tic Tac Toe Game
    /// </summary>
    public partial class Form1 : Form
    {
        clsTicTacToe clsTicTac;
        bool bIsGameStarted;
        string[,] saBoard;
        List<Label> lListOfLabels;

        /// <summary>
        /// init of the form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            LoadLabels();
            saBoard = new string[3, 3];
            clsTicTac = new clsTicTacToe(saBoard);
            clsTicTac.saBoard = saBoard;
            bIsGameStarted = false;
        }
        /// <summary>
        /// Load the labels of the tic tac toe board into a List of labels.
        /// </summary>
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
        /// <summary>
        /// Start button clicked - starting the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            //Need to start the game or set bIsGameStarted variable
            bIsGameStarted = true;
            ClearLabels();
            ResetColors();
        }
        /// <summary>
        /// Space of the gameboard that is clicked. the 9 squares.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Console.WriteLine(myLabel.Text);
                Console.WriteLine(myLabel.Tag);

                string sMark = "";
                if (clsTicTac.eWhoseTurn == clsTicTacToe.Player.player1)
                {
                    sMark = "X";
                } else
                {
                    sMark = "O";
                }
                //LoadBoard(); //broken for some reason

                Int32.TryParse(myLabel.Tag.ToString(), out int myTag);

                switch (myTag)
                {
                    case 00:
                        lblTopLeft.Text = sMark;
                        break;
                    case 01:
                        lblTopMid.Text = sMark;
                        break;
                    case 02:
                        lblTopRight.Text = sMark;
                        break;
                    case 10:
                        lblMidLeft.Text = sMark;
                        break;
                    case 11:
                        lblMidMid.Text = sMark;
                        break;
                    case 12:
                        lblMidRight.Text = sMark;
                        break;
                    case 20:
                        lblBotLeft.Text = sMark;
                        break;
                    case 21:
                        lblBotMid.Text = sMark;
                        break;
                    case 22:
                        lblBotRight.Text = sMark;
                        break;
                    default:
                        break;
                }
                //if IsWinningMove
                HighlightWinningMove();

                //if IsTie()
                // handle tie?

                DisplayScores();
                ChangePlayer();
            }


        }


        #endregion


        #region Helper Methods

        /// <summary>
        /// Start the process of changing the player
        /// </summary>
        private void ChangePlayer()
        {
            clsTicTac.ChangePlayer();
        }
        /// <summary>
        /// Display the scores on the right and bottom.
        /// </summary>
        private void DisplayScores()
        {
            //DisplayScores on the board
        }
        /// <summary>
        /// Highlight winning move
        /// </summary>
        private void HighlightWinningMove()
        {
            //set color of the winning move color`
        }
        /// <summary>
        /// Clear the board of the X and O.
        /// </summary>
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
        /// <summary>
        /// Reset all of the colors to white
        /// </summary>
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
        /// <summary>
        /// Load the values of the board
        /// </summary>
        private void LoadBoard()
        {
            foreach (var item in lListOfLabels)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        item.Text = clsTicTac.saBoard[i, j];

                    }
                }
            }
            
        }
        /// <summary>
        /// Helper method for setting the color of the squares. 
        /// </summary>
        /// <param name="lblLabel"></param>
        /// <param name="changeToColor"></param>
        private void SetBackgroundColor(Label lblLabel, Color changeToColor)
        {
            //lblLabel.BackColor = Color.Yellow;
            lblLabel.BackColor = changeToColor;

        }

        #endregion

    }
}
