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
			lblTiles = new Label[3, 3] {
				{ lblTile1, lblTile2, lblTile3 },
				{ lblTile4, lblTile5, lblTile6 },
				{ lblTile7, lblTile8, lblTile9 } };
			ResetBoard();
		}

		private Label[,] lblTiles;
		private BoardTile[,] bdtBoard;

		private int turns;

		private void ResetBoard()
		{
			bdtBoard = new BoardTile[3, 3];
			turns = 0;
			UpdateBoard();
		}

		private void UpdateBoard()
		{
			for (int i = 0; i < bdtBoard.GetLength(0); i++)
			{
				for (int j = 0; j < bdtBoard.GetLength(1); j++)
				{
					lblTiles[i, j].Text = bdtBoard[i, j].GetDescription();
				}
			}
		}

		private void lblTile_Click(object sender, EventArgs e)
		{
			(int posX, int posY) = GetTilePosition(((Label)sender));
			HandleTilePlacedOn(posX, posY);
		}

		private void HandleTilePlacedOn(int posX, int posY)
		{
			bdtBoard[posX, posY] = turns % 2 == 0 ? BoardTile.X : BoardTile.O;
			turns++;
			UpdateBoard();
			if (turns >= 5) {
				DisplayWinner(CheckWinner());
				if (turns == 9)
				{
					DisplayWinner(Winner.Draw);
				}
			}
		}

		private void DisplayWinner(Winner wnrWinner)
		{
			if(wnrWinner != Winner.None)
			{
				MessageBox.Show(wnrWinner.GetDescription());
				ResetBoard();
			}
		}

		private Winner CheckWinner()
		{
			for (int x = 0; x < bdtBoard.GetLength(0); x++)
			{
				if (bdtBoard[x,0] != BoardTile.Empty && bdtBoard[x, 0] == bdtBoard[x, 1] && bdtBoard[x, 1] == bdtBoard[x, 2])
				{
					return bdtBoard[x, 0].ConvertToWinner();
				}
			}
			for (int y = 0; y < bdtBoard.GetLength(1); y++)
			{

				if (bdtBoard[0, y] != BoardTile.Empty && bdtBoard[0, y] == bdtBoard[1, y] && bdtBoard[1, y] == bdtBoard[2, y])
				{
					return bdtBoard[0, y].ConvertToWinner();
				}
			}

			if (bdtBoard[1,1] != BoardTile.Empty && ((bdtBoard[0, 0] == bdtBoard[1, 1] && bdtBoard[1, 1] == bdtBoard[2, 2]) || ((bdtBoard[2, 0] == bdtBoard[1, 1]) && bdtBoard[1, 1] == bdtBoard[0, 2])))
			{
				return bdtBoard[1, 1].ConvertToWinner();
			}
			return BoardTile.Empty.ConvertToWinner();
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
	}
}
