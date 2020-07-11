using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DICES
{
    class DealDices : MugOfDices
    {
        private Dice[] playerHand;
        private Dice[] computerHand;
        private Dice[] sortedPlayerHand;
        private Dice[] sortedComputerHand;


        public DealDices()
        {
            playerHand = new Dice[5];
            sortedPlayerHand = new Dice[5];
            computerHand = new Dice[5];
            sortedComputerHand = new Dice[5];
        }

        public void Deal()
        {
            setUpDeck();
            getHand();
            sortDices();
            drawDices();
            //evaluateHands();
        }

        public void getHand()
        {
            //5 kart dla gracza
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];

            //5 kart dla komputerowego przeciwnika
            for (int i = 5; i < 10; i++)
                computerHand[i - 5] = getDeck[i];
        }

        public void sortDices()
        {
            var queryPlayer = from hand in playerHand
                              orderby MyValue
                              select hand;

            var queryComputer = from hand in computerHand
                                orderby MyValue
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

        public void drawDices()
        {
            Console.Clear();
            int x = 0;
            int y = 1;

            //pokazuje rękę gracza
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("PLAYER'S HAND");
            for (int i = 0; i < 5; i++)
            {
                DrawDices.DrawDiceOutline(x, y);
                DrawDices.DrawDiceValue(sortedPlayerHand[i], x, y);
                x++;
            }
            y = 9;
            x = 0;

            //pokazuje rękę komputerowego przeciwnika

            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("        ");
            Console.WriteLine("COMPUTER'S HAND");
            Console.SetCursorPosition(x, 9);
            for (int i = 5; i < 10; i++)
            {
                DrawDices.DrawDiceOutline(x, y);
                DrawDices.DrawDiceValue(sortedComputerHand[i - 5], x, y);
                x++;
            }

        }
    }
}
