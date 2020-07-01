using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class ShuffleOfDices : Throws

    {
        private Dice[] playerHand;
        private Dice[] computerHand;
        private Dice[] sortedPlayerHand;
        private Dice[] sortedComputerHand;

        public ShuffleOfDices()
        {
            playerHand = new Dice[5];
            sortedPlayerHand = new Dice[5];
            computerHand = new Dice[5];
            sortedComputerHand = new Dice[5];

        }

        public void ThrowDice()
        {
            setUpMug();
            getHand();
            sortDice();
            displayDice();
            evaluateHands();
        }

        public void getHand()
        {
            for (int i = 0; i < 5; i++)
                playerHand[i] = GetDices[i];

            for (int i = 5; i < 10; i++)
                computerHand[i -5] = GetDices[i];
        }

        public void sortDice()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.MyThrow
                              select hand;

            var queryComputer = from hand in computerHand
                              orderby hand.MyThrow
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

        public void displayDice()
        {
            Console.Clear();
            int x = 0;
            int y = 1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        public void evaluateHands()
        {

        }
    }
}
