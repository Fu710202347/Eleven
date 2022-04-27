using System;
using System.Collections.Generic;

namespace Eleven
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Deck deck = new Deck();
            System system = new System();
            List<Card> Playerhand = new List<Card>();
            GameBoard gameboard = new GameBoard();
            deck.shuffle();
            system.dealCards(deck, 9, Playerhand);
            while (game == true)
            {
                Console.WriteLine("Enter 1 to Start Game\n" + "Enter 2 to Display Wins Over Total\n" + "Enter 3 to end the Game\n");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        gameboard.PlayGame(Playerhand, deck);
                        break;
                    case 2:
                        gameboard.GamePlayedOverWins();
                        break;
                    case 3:
                        game = false;
                        break;
                }

               
            }
            
            


        }
    }
}
