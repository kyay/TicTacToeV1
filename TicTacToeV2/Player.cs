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
        private Winner winner;
        private int winCount;
        private int lossCount;
        private int drawCount;
        private string playerName;
        private int fastestGameTime = int.MaxValue;
        private int gameTime;

        public Winner Winner
        {
            get
            {
                return winner;
            }
        }
        public int WinCount
        {
            get
            {
                return winCount;
            }
        }
        public int LossCount
        {
            get
            {
                return lossCount;
            }
        }
        public int DrawCount
        {
            get
            {
                return drawCount;
            }
        }
        public string PlayerName
        {
            get
            {
                return playerName;
            }
        }
        public int FastestGameTime
        {
            get
            {
                return fastestGameTime;
            }
        }

        public int GameTime
        {
            get
            {
                return gameTime;
            }
            set
            {
                gameTime = value;
            }
        }

        public Player()
        {
            winner = Winner.None;
            playerName = strDefaultName;
        }

        public Player(Winner wnrWinner, string strPlayerName = "")
        {
            this.winner = wnrWinner;
            if (strPlayerName == "")
            {
                this.winner = wnrWinner;
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
            playerName = strPlayerName;
        }

        public void OnWinnerAnnounced(Winner wnrNewWinner)
        {
            if (wnrNewWinner == Winner || Winner.GetDrawEquivalentForWinner() == wnrNewWinner)
                winCount++;
            else if (wnrNewWinner == Winner.Draw)
                drawCount++;
            else if (wnrNewWinner == Winner.None)
            {
                //Do Nothing
            }
            else
                lossCount++;

        }

        public void OnGameEnded()
        {
            fastestGameTime = GameTime < FastestGameTime ? GameTime : FastestGameTime;
        }

        public override string ToString()
        {
            return "Player name: " + PlayerName + "\n" + 
                "Player symbol: " + Winner.ToString() + "\n" +
                "Win count: " + WinCount + "\n" +
                "Loss count: " + LossCount + "\n" +
                "Draw count: " + DrawCount + "\n" +
                "Fastest Game Time: " + (FastestGameTime == int.MaxValue ? "Not set" : FastestGameTime.ToString());
        }
    }
}
