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

            //** example program **
            //cast the sender to label
            //label myLabel = (Label)sender;
            //mylabel.text = "x";
            //setBackgroundColor(myLabel);
        }

        #endregion


        //TODO: Create ClearLabels() and a ResetColors()
        //TODO: LoadBoard()
        //TODO: SetBackgroundColor(Label lblLabel)

        private void ClearLabels()
        {
            //change the text of the labels
            lblTopLeft.Text = "";
            lblTopMid.Text = "";
            lblTopRight.Text = "";

            lblMidLeft.Text = "";
            lblMidMid.Text = "";
            lblMidRight.Text = "";

            lblBotLeft.Text = "";
            lblBotMid.Text = "";
            lblBotRight.Text = "";

        }
        private void ResetColors()
        {

        }
        private void LoadBoard()
        {

        }
        private void SetBackgroundColor(Label lblLabel)
        {
            //lblLabel.BackColor = Color.Yellow;
        }

    }
}
