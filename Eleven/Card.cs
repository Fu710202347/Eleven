using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven
{
    class Card
    {
        private int CardRank;
        private string CardSuit;

        public Card(int CardRank, string CardSuit)
        {
            this.CardRank = CardRank;
            this.CardSuit = CardSuit;
        }

        public int Rank
        {
            get { return CardRank; }
            set { Rank = value; }
        }
        public string Suit
        {
            
            get { return CardSuit; }
            set { Suit = value; }
        }
    }
}
