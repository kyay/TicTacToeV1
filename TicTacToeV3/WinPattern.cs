using System.ComponentModel;

namespace TicTacToeV1
{
    //An enum that specifies all the possible win patterns that a player can use to win
	public enum WinPattern
	{
        //Specifies that there is no win pattern at all, which is the default value
		None,

        //All the three horizontal rows, from top to bottom
		Row1,
		Row2,
		Row3,

        //All the three vertical columns, from left to right
        Column1,
		Column2,
		Column3,

        //The forward diagonal \
		Diagonal1,
        //The backward diagonal /
		Diagonal2
	}
}
