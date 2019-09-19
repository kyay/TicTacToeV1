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

        //Resets the board visually and in the underlying data
		private void ResetBoard()
		{
            //Reset all the board tiles to BoardTile.Empty (which is the default value because it is the first value)
			bdtBoard = new BoardTile[3, 3];
            //Reset the number of turns
			intTurns = 0;
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
			HandleTilePlacedOn(posX, posY);
		}

		private void HandleTilePlacedOn(int posX, int posY)
		{
			bdtBoard[posX, posY] = intTurns % 2 == 0 ? BoardTile.X : BoardTile.O;
			intTurns++;
			UpdateBoard();
			if (intTurns >= 5) {
				(Winner winner, WinPattern wptPattern) = CheckWinner();
				DisplayWinner(winner, wptPattern);
				if (intTurns == 9)
				{
					DisplayWinner(Winner.Draw);
				}
			}
		}

		private void DisplayWinner(Winner winner, WinPattern wptPattern)
		{
			if(wptPattern != WinPattern.None)
			{
				foreach((int x, int y) in wptPattern.GetTilePositions())
				{
					lblTiles[x, y].BackColor = bdtBoard[x, y].GetCorrespondingColor();
                    lblTiles[x, y].ForeColor = SystemColors.ControlText;
				}
				DisplayWinner(winner);
			}
		}
		private void DisplayWinner(Winner wnrWinner)
		{
			if(wnrWinner != Winner.None)
			{
                switch (wnrWinner)
                {
                    case Winner.X:
                        intXScore++;
                        break;
                    case Winner.O:
                        intOScore++;
                        break;
                }
                UpdateScore();
				MessageBox.Show(wnrWinner.GetDescription());
				ResetBoard();
			}
		}

		private (Winner, WinPattern) CheckWinner()
		{
			foreach(WinPattern wptPattern in Enum.GetValues(typeof(WinPattern)))
			{
				if (wptPattern == WinPattern.None)
					continue;
				BoardTile bdtWinnerTile = wptPattern.FollowsPattern(bdtBoard);
				if (bdtWinnerTile != BoardTile.Empty)
				{
					return (bdtWinnerTile.ConvertToWinner(), wptPattern);
				}
			}
			return (BoardTile.Empty.ConvertToWinner(), WinPattern.None);
		}

		private (int, int) GetTilePosition(Label lblTile)
		{
			for (int i = 0; i < lblTiles.GetLength(0); i++)
			{
				for (int j = 0; j < lblTiles.GetLength(1); j++)
				{
					if (lblTile == lblTiles[i, j])
					{
						return (i, j);
					}
				}
			}
			throw new ArgumentException("Label not found in the tiles array.");
		}
        
        private void UpdateScore()
        {
            lblXScore.Text = "X: " + intXScore;
            lblOScore.Text = "O: " + intOScore;
        }
	}
}
