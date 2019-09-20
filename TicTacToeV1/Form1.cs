using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeV1
{
	public partial class frmTicTacToe : Form
	{
		public frmTicTacToe()
		{
			InitializeComponent();
            //Initialize all the labels for the tiles in their correct positions
			lblTiles = new Label[3, 3] {
				{ lblTile1, lblTile2, lblTile3 },
				{ lblTile4, lblTile5, lblTile6 },
				{ lblTile7, lblTile8, lblTile9 } };
			ResetBoard();
		}

        //The on-screen lables that correspond with the board tiles
		private Label[,] lblTiles;
        //The 2d array that holds the data describing all the board tiles
		private BoardTile[,] bdtBoard;

        //The number of turns played
		private int intTurns = 0;

        private int intXScore = 0;
        private int intOScore = 0;

        private int intXTime = 0;
        private int intOTime = 0;

        //Resets the board visually and in the underlying data
        private void ResetBoard()
		{
            //Reset all the board tiles to BoardTile.Empty (which is the default value because it is the first value)
			bdtBoard = new BoardTile[3, 3];
            //Reset the number of turns
			intTurns = 0;
            intXTime = 0;
            intOTime = 0;
            //Update the score on the screen
            UpdateScore();
            //Update the visual labels so that they are in sync with the board
			UpdateBoard();
		}

        //Updates the visual board
		private void UpdateBoard()
		{
            //Loop over each label
			for (int i = 0; i < bdtBoard.GetLength(0); i++)
			{
				for (int j = 0; j < bdtBoard.GetLength(1); j++)
				{
                    //Get the current tile and its corresponding label
                    BoardTile bdtCurTile = bdtBoard[i, j];
                    Label lblCurTile = lblTiles[i, j];
                    //Update the label's text and colors to reflect the symbol that it has
                    lblCurTile.Text = bdtCurTile.GetDescription();
                    lblCurTile.BackColor = SystemColors.Control;
                    lblCurTile.ForeColor = bdtCurTile.GetCorrespondingColor();
                }
			}
		}

		private void lblTile_Click(object sender, EventArgs e)
		{
            //Get the position of the label that was clicked
			(int posX, int posY) = GetTilePosition(((Label)sender));
            if(bdtBoard[posX, posY] == BoardTile.Empty)
                //Add the user's symbol to that position on the board array
			    HandleTilePlacedOn(posX, posY);
		}

		private void HandleTilePlacedOn(int posX, int posY)
		{
            //X plays on even turns, O plays on odd turns
			bdtBoard[posX, posY] = intTurns % 2 == 0 ? BoardTile.X : BoardTile.O;
			intTurns++;
            //Display the new changes on the UI
			UpdateBoard();
            //A win can only be achieved with at least five turns, so only check for a winner if 5 turns have passed
			if (intTurns >= 5) {
                //Get the winner and the pattern that they used as a ValueTuple
				(Winner winner, WinPattern wptPattern) = CheckWinner();
                //Display the winner and highlight their pattern
				DisplayWinner(winner, wptPattern);
                //Display winner will reset the turns if there is a winner, so if it didn't reset, and there are no open positions, then it's a draw
				if (intTurns == 9)
				{
					DisplayWinner(Winner.Draw);
				}
			}
		}

        //An overload of DisplayWinner(Winner) that also takes in the winning pattern to highlight it on the screen
		private void DisplayWinner(Winner winner, WinPattern wptPattern)
		{
            //If there is no winning pattern, then there is definetly no winner, so just skip the highlighting and the winner-displaying part
			if(wptPattern != WinPattern.None)
			{
                //For each position in that winning pattern
				foreach((int x, int y) in wptPattern.GetTilePositions())
				{
                    //Color its background with the symbol's color
					lblTiles[x, y].BackColor = bdtBoard[x, y].GetCorrespondingColor();
                    //And color its text with the default color
                    lblTiles[x, y].ForeColor = SystemColors.ControlText;
				}
                //Call the DisplayWinner(Winner) function to show the actual message box
				DisplayWinner(winner);
			}
		}
        //Displays the winner in a message box on the screen
		private void DisplayWinner(Winner wnrWinner)
		{
            //If there is a winner
			if(wnrWinner != Winner.None)
			{
                //handle the score incrementing
                switch (wnrWinner)
                {
                    case Winner.X:
                        intXScore++;
                        break;
                    case Winner.O:
                        intOScore++;
                        break;
                }
                //Show the score on the screen
                UpdateScore();
                //Show the winning message based on the winner (this is an extension function)
				MessageBox.Show(wnrWinner.GetDescription() + (wnrWinner == Winner.Draw ? (intXTime < intOTime ? " But X took less time, so X wins" : (intOTime < intXTime ? " But O took less time, so O wins" : "")) : ""));
                //Reset the board to its original state
				ResetBoard();
			}
		}

        /*
         * Checks if there is a winner
         * If there is one, it also returns the pattern that the winner used
         * If there isn't a winner, it returns Winner.None with WinPattern.None
         */
		private (Winner, WinPattern) CheckWinner()
		{
            //For each possible winning pattern
			foreach(WinPattern wptPattern in Enum.GetValues(typeof(WinPattern)))
			{
                //Skip the None pattern because it is not applicable in this case
				if (wptPattern == WinPattern.None)
					continue;
                //Check if the board follows that specific pattern and get the BoardTile type that actually follows it
				BoardTile bdtWinnerTile = wptPattern.FollowsPattern(bdtBoard);
                //FollowsPattern will return BoardTile.Empty if the board doesn't follow the pattern or if empty tiles follow that pattern, so we need to check for that
				if (bdtWinnerTile != BoardTile.Empty)
				{
                    //We have a winner!! return it and its winning pattern. The foreach loop will also halt now, so we don't need to break
					return (bdtWinnerTile.ConvertToWinner(), wptPattern);
				}
			}
            //Return an empty winner with no pattern
			return (BoardTile.Empty.ConvertToWinner(), WinPattern.None);
		}

        //Gets the position of the provided label in the label array and returns it as a ValueTuple
		private (int, int) GetTilePosition(Label lblTile)
		{
            //Loop over all rows
			for (int i = 0; i < lblTiles.GetLength(0); i++)
			{
                //Loop over all columns
				for (int j = 0; j < lblTiles.GetLength(1); j++)
				{
                    //If the current label matches the specified label
					if (lblTile == lblTiles[i, j])
					{
                        //Return its position as a ValueTuple
						return (i, j);
					}
				}
			}
            //Notify the programmer that they provided a wrong label
			throw new ArgumentException("Label not found in the tiles array.");
		}
        
        //Updates the scores for X and O
        private void UpdateScore()
        {
            lblXScore.Text = "X: " + intXScore;
            lblOScore.Text = "O: " + intOScore;
        }

        private void trmPlayerTimeCounter_Tick(object sender, EventArgs e)
        {
            if (intTurns % 2 == 0)
                intXTime++;
            else
                intOTime++;
        }
    }
}
