using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV1
{
	public static class EnumUtils
	{
		public static string GetDescription(this Enum en)
		{
			try
			{
				return ((DescriptionAttribute)(en.GetType().GetMember(en.ToString()).FirstOrDefault()
					.GetCustomAttributes(typeof(DescriptionAttribute), true)[0])).Description;
			}
			catch (Exception e)
			{
				return en.ToString();
			}
		}

		public static Winner ConvertToWinner(this BoardTile bdtWinnerTile)
		{
			switch (bdtWinnerTile)
			{
				case BoardTile.X:
					return Winner.X;
				case BoardTile.O:
					return Winner.O;
				default:
					return Winner.None;
			}
		}

		public static (int, int)[] GetTilePositions(this WinPattern wptPattern)
		{
			int x = -1;
			int y = -1;
			switch (wptPattern)
			{
				case WinPattern.Column1:
					x = 0;
					goto case WinPattern.Column3;
				case WinPattern.Column2:
					x = 1;
					goto case WinPattern.Column3;
				case WinPattern.Column3:
					x = x == -1 ? 2 : x;
					return new(int, int)[] { (x, 0), (x, 1), (x, 2) };
				case WinPattern.Row1:
					y = 0;
					goto case WinPattern.Row3;
				case WinPattern.Row2:
					y = 1;
					goto case WinPattern.Row3;
				case WinPattern.Row3:
					y = y == -1 ? 2 : y;
					return new(int, int)[] { (0, y), (1, y), (2, y) };
				case WinPattern.Diagonal1:
					return new(int, int)[] { (0, 0), (1, 1), (2, 2) };
				case WinPattern.Diagonal2:
					return new(int, int)[] { (2, 0), (1, 1), (0, 2) };
				default:
					throw new ArgumentException("The provided WinPattern is not supported");
			}
		}
		public static BoardTile FollowsPattern(this WinPattern wptPattern, BoardTile[,] bdtBoard)
		{
			(int, int)[] intPatternPositions = wptPattern.GetTilePositions();
			BoardTile bdtFirstTile = bdtBoard[intPatternPositions[0].Item1, intPatternPositions[0].Item2];
			foreach((int x, int y) in intPatternPositions)
			{
				if (bdtBoard[x, y] != bdtFirstTile)
					return BoardTile.Empty;
			}
			return bdtFirstTile;
		}
	}
}
