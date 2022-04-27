using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven
{
    class Deck
    {
        List<Card> deck = new List<Card>();
        string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };

        public bool CheckWinOrLose()
        {
            for(int i = 0; i <deck.Count;i++)
            {
                for(int j = 0; j < deck.Count; j++)
                {
                    if (deck[i].Rank + deck[j].Rank == 11)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool checkDeckCount()
        {
            if (deck.Count == 0)
            {
                return true;
            }
            return false;

        }
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    deck.Add(new Card(j, suit[i]));
                }
            }
        }
        public void shuffle()
        {
            Random rnd = new Random();
            for(int i = deck.Count - 1; i >0; i--)
            {
                int RandomIndex = rnd.Next(i + 1);
                Card TempCard = deck[i];
                deck[i] = deck[RandomIndex];
                deck[RandomIndex] = TempCard;
            }
        }
        public Card TopCard()
        {
            if(deck.Count>0)
            {
                Card topcard = deck[deck.Count - 1];
                deck.RemoveAt(deck.Count - 1);
                return topcard;
            }
            return null;
        }
        public void Print()
        {
            for(int i = 0; i< deck.Count;i++)
            {
                Console.WriteLine(deck[i].Rank + " " + deck[i].Suit);
            }
        }
    }
}
