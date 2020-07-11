using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    // rozdaj kości z kubka dla dwóch graczy
    class DealDices : MugOfDices

    {
        private Dice[] playerHand; // player 1
        private Dice[] computerHand; // player 2
        
        public DealDices()
        {
            playerHand = new Dice[5]; // 5 kości dla gracza           
            computerHand = new Dice[5]; // 5 kości dla komputerowego przeciwnika        

        }

        public void Deal()
        {
            setUpDeck();
            getHand();
            sortDices(); 
            displayDices();
            evaluateHands();
        }

        public void getHand()
        {
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];

             for (int i = 5; i < 10; i++)
                computerHand[i -5] = getDeck[i]; 
        }

        public void sortDices()
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
                playerHand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryComputer.ToList())
            {
                computerHand[index] = element;
                index++;
            }

        }
        
        public void displayDices()
        {
            Console.Clear();
            int x = 0;
            int y = 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PLAYER`S HAND");
            for (int  i = 0; i < 5; i++)
            {
                DrawDices.DrawDiceOutline(x, y);
                DrawDices.DrawDiceValue(playerHand[i], x, y);
                x++;             
            }            
            y = 15;
            x = 0;            
            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("COMPUTER`S HAND");         
            for (int i = 5; i < 10; i++)
            {
                DrawDices.DrawDiceOutline(x, y);
                DrawDices.DrawDiceValue(computerHand[i - 5], x, y);
                x++;
            }

        }

        public void evaluateHands()
        {

        }
    }
}
