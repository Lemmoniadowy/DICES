using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class DealCards : MugOfDices

    {
        private Dice[] playerHand;
        private Dice[] computerHand;    
        
        public DealCards()
        {
            playerHand = new Dice[5];            
            computerHand = new Dice[5];            

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
        public void displayDices()
        {
            Console.Clear();
            int x = 0;
            int y = 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PLAYER`S HAND");
            for (int  i = 0; i < 5; i++)
            {
                DrawDices.DrawDiceCubeOutline(x, y);
                DrawDices.DrawDiceSuitValue(playerHand[i], x, y);
                x++;             
            }            
            y = 15;
            x = 0;            
            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("COMPUTER`S HAND");         
            for (int i = 5; i < 10; i++)
            {
                DrawDices.DrawDiceCubeOutline(x, y);
                DrawDices.DrawDiceSuitValue(computerHand[i - 5], x, y);
                x++;
            }

        }

        public void evaluateHands()
        {

        }
    }
}
