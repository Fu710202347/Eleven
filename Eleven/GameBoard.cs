using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleven
{
    
    
    class GameBoard
    {
        private int wins = 0;
        private int loses = 0;
        private int totalgame = 0;
        
        public void PlayGame(List<Card>Playerhand, Deck deck)
        {
            System system = new System();
            bool Game = true;
            while (system.CheckPlayerhand(Playerhand) && deck.CheckWinOrLose() && Game == true)
            {
                system.showHand(Playerhand);
                Console.WriteLine("\n"+"Enter 1 to Remove JQK" + "\n" + "Enter 2 to Remove Eleven" + "\n" + "Enter 3 to surrender\n");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select JQK");
                        int card1 = Int32.Parse(Console.ReadLine());
                        int card2 = Int32.Parse(Console.ReadLine());
                        int card3 = Int32.Parse(Console.ReadLine());
                        card1--;
                        card2--;
                        card3--;
                        if (system.ReplaceableForJQK(Playerhand,card1,card2,card3))
                        {
                            system.replaceCards(deck, Playerhand, card1, card2, card3);
                            
                            Console.WriteLine("\n Cards Removed \n ______________");
                        }
                        else
                        {
                            Console.WriteLine("\nIncorrect Combination" + "\n" +"______________________");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Select ELeven");
                        int card = Int32.Parse(Console.ReadLine());
                        int SecCard = Int32.Parse(Console.ReadLine());
                        card--;
                        SecCard--;
                        if(system.ReplaceAbleForEleven(Playerhand,card,SecCard))
                        {
                            system.replaceCards(deck, Playerhand, card, SecCard);
                            
                            Console.WriteLine("\n Cards Removed \n ______________");

                        }
                        else
                        {
                            Console.WriteLine("\nIncorrect Combination" + "\n" + "______________________");
                        }
                        break;
                    case 3:
                        Game = false;
                        break;

                }
                
            }
            totalgame++;
            if(deck.checkDeckCount())
            {
                Console.WriteLine("You Won");
                wins++;
            }
            else
            {
                Console.WriteLine("You lost \n");
                loses++;
            }
        }
        public void GamePlayedOverWins()
        {
            Console.WriteLine("Wins Over Total Games: " + wins + " out of " + totalgame + "\n");
        }
    }
}
