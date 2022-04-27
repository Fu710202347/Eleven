using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven
{
    class System
    {
        public void replaceCards(Deck d, List<Card>List, params int []CardIdxToReplace)// action of actually replacing the cards
        {
           for(int i = 0; i < CardIdxToReplace.Length; i++)
            {
                List.RemoveAt(CardIdxToReplace[i]);
                List.Add(d.TopCard());
            }
        }

        public void dealCards(Deck d, int CardCount, List<Card>Playerhand)
        {
            for(int i = 0; i < CardCount; i++)
            {
                Playerhand.Add(d.TopCard());
            }
        }
        public bool CheckPlayerhand(List<Card>Playerhand)
        {
            for(int i = 0; i < Playerhand.Count;i++)
            {
                for(int j = 0; j <Playerhand.Count; j++)
                {
                    if (Playerhand[i].Rank + Playerhand[j].Rank == 11)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void showHand(List<Card>PlayerHand)
        {
            int cardnum = 1;
            for (int i = 0; i < PlayerHand.Count(); i++)
            {
                Console.WriteLine(+PlayerHand[i].Rank + " " + PlayerHand[i].Suit + "-> " + "Card " + cardnum);
                cardnum++;
            }
        }
        public int totalRank()
        {
            return 0;
        }
        public void checker()
        {
            Deck d = new Deck();
            if (d.CheckWinOrLose())
                Console.WriteLine("Keep it up");
            else
                Console.WriteLine("You lose");
        }
        public bool ReplaceableForJQK(List<Card> Playerhand, int card1, int card2, int card3)
        {
            if (Playerhand[card1].Rank + Playerhand[card2].Rank + Playerhand[card3].Rank == 34)
            {
                return true;
            }
            return false;
        }
        public bool ReplaceAbleForEleven(List<Card> Playerhand , int card1, int card2)
        {
            if(Playerhand[card1].Rank + Playerhand[card2].Rank == 11)
            {
                return true;
            }
            return false;
        }

    }
}
