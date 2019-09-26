using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV1
{
    public class Player
    {
        public const string strDefaultXName = "X";
        public const string strDefaultOName = "O";
        public const string strDefaultDrawName = "Draw";
        public const string strDefaultName = "Default";
        public Winner wnrWinner { get; private set; }
        public int intWinCount { get; private set; }
        public int intLossCount { get; private set; }
        public int intDrawCount { get; private set; }
        public string strPlayerName { get; private set; }
        public int intFastestGameTime { get; private set; }
        public int intGameTime { get; set; }

        public Player()
        {
            wnrWinner = Winner.None;
            strPlayerName = strDefaultName;
        }

        public Player(Winner wnrWinner, string strPlayerName = "")
        {
            this.wnrWinner = wnrWinner;
            if(strPlayerName == "")
            {
                this.wnrWinner = wnrWinner;
                switch (wnrWinner)
                {
                    case Winner.X:
                        strPlayerName = strDefaultXName;
                        break;
                    case Winner.O:
                        strPlayerName = strDefaultOName;
                        break;
                    default:
                        strPlayerName = strDefaultName;
                        break;
                }
            }
            this.strPlayerName = strPlayerName;
        }

        public void OnWinnerAnnounced(Winner wnrNewWinner)
        {
            if (wnrNewWinner == wnrWinner)
                intWinCount++;
            else if (wnrNewWinner == Winner.Draw)
                intDrawCount++;
            else if (wnrNewWinner == Winner.None)
            {
                //Do Nothing
            }
            else
                intLossCount++;

        }

        public void OnGameEnded()
        {
            intFastestGameTime = intGameTime < intFastestGameTime ? intGameTime : intFastestGameTime;
        }

    }
}
