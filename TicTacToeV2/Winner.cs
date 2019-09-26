using System.ComponentModel;

namespace TicTacToeV1
{
    //An enum that represent the winner of a round of Tic Tac Toe
	public enum Winner
	{
        //There is no winner and it isn't a draw
		None,
        //The winner is X
		[Description("{0} wins!!")]
		X,
        //The winner is O
        [Description("{0} wins!!")]
		O,
        //There is no winner and it's a draw
        [Description("It's a {0}!!!")]
		Draw
	}
}
