using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class MugOfDices : Dice
    {
        const int NUMBER_OF_DICES = 10;
        private Dice[] deck; 
        
        public MugOfDices()
        {
            deck = new Dice[NUMBER_OF_DICES];
        }

        public Dice[] getDeck { get { return deck; } }

        public void setUpDeck()
        {
            int i = 0;            
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Dice { MyValue = v };                    
                }

            }

            // MugShuffler();

        }

        /* public void MugShuffler ()
        {
            Random rand = new Random();
            Dice temp; 

            for (int shuffleTimes = 0; shuffleTimes <100; shuffleTimes++)
            {
                for (int i = 0; i < NUMBER_OF_DICES; i++ )
                {
                    int secondDiceIndex = rand.Next(5);
                    temp = dice[i];
                    dice[i] = dice[secondDiceIndex];
                    dice[secondDiceIndex] = temp;
                }
            }
        }
        */
    }
}
