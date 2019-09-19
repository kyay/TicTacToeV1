using System.ComponentModel;

namespace TicTacToeV1
{
	public enum Winner
	{
		None,
		[Description("X wins!!")]
		X,
		[Description("O wins!!")]
		O,
		[Description("It's a draw!!!")]
		Draw
	}
}
