using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV1
{
    //A class that has various methods for dealing with enums generally and our specific enums.
    public static class EnumUtils
    {

        //Returns either the DescriptionAttribute value of this enum or its string representation if it doesn't have one
        public static string GetDescription(this Enum en)
        {
            try
            {
                //Get the MemberInfo object for that specific enum value from its enum Type and then get the DescriptionAttribute from it and retrieve the description from that
                return ((DescriptionAttribute)(en.GetType().GetMember(en.ToString()).FirstOrDefault()
                    .GetCustomAttributes(typeof(DescriptionAttribute), true)[0])).Description;
            }
            catch (Exception)
            {
                //Failsafe: just return the string representation of that enum value
                return en.ToString();
            }
        }

        //Converts a board tile to a winner
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

        //Gets the tile positions that this pattern follows
        public static (int, int)[] GetTilePositions(this WinPattern wptPattern)
        {
            int x = -1;
            int y = -1;
            switch (wptPattern)
            {
                //Handles rows
                case WinPattern.Row1:
                    x = 0;
                    goto case WinPattern.Row3;
                case WinPattern.Row2:
                    x = 1;
                    goto case WinPattern.Row3;
                case WinPattern.Row3:
                    //If x wasn't set by any past Row, then set it to 2
                    x = x == -1 ? 2 : x;
                    //Return a row pattern
                    return new (int, int)[] { (x, 0), (x, 1), (x, 2) };
                //Handles columns
                case WinPattern.Column1:
                    y = 0;
                    goto case WinPattern.Column3;
                case WinPattern.Column2:
                    y = 1;
                    goto case WinPattern.Column3;
                case WinPattern.Column3:
                    //If y wasn't set by any past Column, then set it to 2
                    y = y == -1 ? 2 : y;
                    //Return a column pattern
                    return new (int, int)[] { (0, y), (1, y), (2, y) };
                //Handles diagonals
                case WinPattern.Diagonal1:
                    return new (int, int)[] { (0, 0), (1, 1), (2, 2) };
                case WinPattern.Diagonal2:
                    return new (int, int)[] { (2, 0), (1, 1), (0, 2) };
                //We don't care about any other pattern, so throw an exception
                default:
                    throw new ArgumentException("The provided WinPattern is not supported");
            }
        }
        //Checks to see if the 2d array of BoardTiles matches the pattern defined in the WinPattern, and if so, returns which type of tile follows it.
        //If the board doesn't follow the pattern, this function returns BoardTile.Empty
        public static BoardTile FollowsPattern(this WinPattern wptPattern, BoardTile[,] bdtBoard)
        {
            (int, int)[] intPatternPositions = wptPattern.GetTilePositions();
            BoardTile bdtFirstTile = bdtBoard[intPatternPositions[0].Item1, intPatternPositions[0].Item2];
            foreach ((int x, int y) in intPatternPositions)
            {
                if (bdtBoard[x, y] != bdtFirstTile)
                    return BoardTile.Empty;
            }
            return bdtFirstTile;
        }

        //Returns the respective color for the specified BoardTile
        public static Color GetCorrespondingColor(this BoardTile bdtTile)
        {
            switch (bdtTile)
            {
                case BoardTile.X:
                    return Color.DarkCyan;
                case BoardTile.O:
                    return Color.DarkOrange;
                default:
                    return SystemColors.Control;
            }
        }

        public static string GetWinMessage(this Winner wnrWinner, params Player[] plrPlayers)
        {
            string strWinMessage = "";
            //Player plrFastestPlayer = null;
            foreach (Player plrPlayer in plrPlayers)
            {
                if (plrPlayer.Winner == wnrWinner || plrPlayer.Winner.GetDrawEquivalentForWinner() == wnrWinner)
                {
                    strWinMessage = string.Format(wnrWinner.GetDescription(), plrPlayer.PlayerName, Player.strDefaultDrawName);
                }
                //if (plrFastestPlayer == null || plrFastestPlayer.FastestGameTime > plrPlayer.FastestGameTime)
                //{
                //    plrFastestPlayer = plrPlayer;
                //}
            }

            if (strWinMessage == "")
                switch (wnrWinner)
                {
                    case Winner.X:
                        strWinMessage = string.Format(wnrWinner.GetDescription(), Player.strDefaultXName);
                        break;
                    case Winner.O:
                        strWinMessage = string.Format(wnrWinner.GetDescription(), Player.strDefaultOName);
                        break;
                    case Winner.Draw:
                        strWinMessage = string.Format(wnrWinner.GetDescription(), Player.strDefaultDrawName);
                        break;
                    case Winner.DrawX:
                        strWinMessage = string.Format(wnrWinner.GetDescription(), Player.strDefaultXName, Player.strDefaultDrawName);
                        break;
                    case Winner.DrawO:
                        strWinMessage = string.Format(wnrWinner.GetDescription(), Player.strDefaultOName, Player.strDefaultDrawName);
                        break;
                    default:
                        strWinMessage = string.Format(wnrWinner.GetDescription(), Player.strDefaultName);
                        break;

                }
            //if (plrFastestPlayer != null)
            //    strWinMessage += (wnrWinner == Winner.Draw ? " But " + plrFastestPlayer.PlayerName + " took less time, so " + plrFastestPlayer.PlayerName + " wins" : "");
            return strWinMessage;

        }
        public static Winner GetDrawEquivalentForWinner(this Winner wnrWinner)
        {
            switch (wnrWinner)
            {
                case Winner.X:
                    return Winner.DrawX;
                case Winner.O:
                    return Winner.DrawO;
                default:
                    return Winner.Draw;
            }
        }
    }
}
