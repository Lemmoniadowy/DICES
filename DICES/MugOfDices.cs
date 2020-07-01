using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class DeckOfDices : Dice
    {
        const int NUMBER_OF_DICES = 5;
        private Dice[] deck; 
        
        public DeckOfDices()
        {
            deck = new Dice[NUMBER_OF_DICES];
        }

        public Dice[] getDeck { get { return deck; } }

        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT c in Enum.GetValues(typeof(SUIT)))
            {
                foreach (THROW t in Enum.GetValues(typeof(THROW)))
                {
                    deck[i] = new Dice { MyColor = c, MyThrow = t };
                    
                }

            }

            MugShuffler();

        }

        public void MugShuffler ()
        {
            Random rand = new Random();
            Dice temp; 

            for (int shuffleTimes = 0; shuffleTimes <100; shuffleTimes++)
            {
                for (int i = 0; i < NUMBER_OF_DICES; i++ )
                {
                    int secondDiceIndex = rand.Next(5);
                    temp = deck[i];
                    deck[i] = deck[secondDiceIndex];
                    deck[secondDiceIndex] = temp;
                }
            }
        }

    }
}
