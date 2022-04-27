using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven
{
    class Player
    {
        private string playerName;
        private int playerRank;
        public Player(string name, int Rank)
        {
            this.playerName = name;
            this.playerRank = Rank;
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int PlayerRank
        {
            get{ return playerRank; }
            set { playerRank = value; }

        }
        public void LeaderBoard()
        {

        }
    }
}
