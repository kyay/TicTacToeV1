using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV1
{
    class Player
    {
        public Winner wnrWinner { get; private set; }
        public int intWinCount { get; private set; }
        public int intLossCount { get; private set; }
        public int intDrawCount { get; private set; }
        public string strPlayerName { get; private set; }
        public int intFastestTime { get; private set; }

        public Player()
        {
            wnrWinner = Winner.None;
            strPlayerName = "Default";
        }

        public Player(Winner wnrWinner, string strPlayerName)
        {
            this.wnrWinner = wnrWinner;
            this.strPlayerName = strPlayerName;
        }

        public void ChangeScore(Winner wnrNewWinner)
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

        public void CompareGameTime(int intNewGameTime)
        {
            intFastestTime = intNewGameTime < intFastestTime ? intNewGameTime : intFastestTime;
        }

    }
}
