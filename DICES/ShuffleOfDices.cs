using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class DealCards : DeckOfCards

    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] sortedPlayerHand;
        private Card[] sortedComputerHand;

        public DealCards()
        {
            playerHand = new Card[5];
            sortedPlayerHand = new Card[5];
            computerHand = new Card[5];
            sortedComputerHand = new Card[5];

        }

        public void Deal()
        {
            setUpDeck();
            getHand();
            /* sortCards(); */
            displayCards();
            evaluateHands();
        }

        public void getHand()
        {
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];

             for (int i = 5; i < 10; i++)
                computerHand[i -5] = getDeck[i]; 
        }

        /* public void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.MyValue
                              select hand;

            var queryComputer = from hand in computerHand
                              orderby hand.MyValue
                              select hand;

            var index = 0;
            foreach (var element in queryPlayer.ToList())
            {
                sortedPlayerHand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryComputer.ToList())
            {
                sortedComputerHand[index] = element;
                index++;
            }

        }
        */
        public void displayCards()
        {
            Console.Clear();
            int x = 0;
            int y = 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("PLAYER`S HAND");
            for (int  i = 0; i < 5; i++)
            {
                DrawCards.DrawCubeOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedPlayerHand[i], x, y);
                x++;             
            }            
            y = 15;
            x = 0;            
            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("COMPUTER`S HAND");         
            for (int i = 5; i < 10; i++)
            {
                DrawCards.DrawCubeOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedComputerHand[i - 5], x, y);
                x++;
            }

        }

        public void evaluateHands()
        {

        }
    }
}
