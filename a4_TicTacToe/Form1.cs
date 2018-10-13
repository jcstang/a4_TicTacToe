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

        private void start_Click(object sender, EventArgs e)
        {
            //Need to start the game or set bIsGameStarted variable
            //clearLabels() and ResetColors()
        }

        //TODO: space clicked
            //1. bIsGameStarted
            //2. is space blank
            //3. LoadBoard()
            //4. clsTicTac.IsWinningMove()
            //5. HighlightWinningMove() and DisplayScores()
            //6. clsTicTac.IsTie()
            //7. DisplayScores() [game over]


        //TODO: lblSpace_Click(object sender, EventArgs e)
            //cast the sender to label
            //label myLabel = (Label)sender;
            //mylabel.text = "x";
            //setBackgroundColor(myLabel);


        //TODO: Create ClearLabels() and a ResetColors()
        //TODO: LoadBoard()
        //TODO: SetBackgroundColor(Label lblLabel)
            //lblLabel.BackColor = Color.Yellow;

    }
}
