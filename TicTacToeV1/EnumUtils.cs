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
	}
}
