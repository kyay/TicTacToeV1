using System.ComponentModel;

namespace TicTacToeV1
{
    //Represents a tile on the board.
	public enum BoardTile
	{
		[Description("")]
        //An empty tile that has nothing in it at all
		Empty,
        //A tile with an X in it
		X,
        //A tile with an O in it
        O
    }
}
