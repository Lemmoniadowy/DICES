using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class DeckOfCards : Card
    {
        const int NUMBER_OF_DICES = 10;
        private Card[] deck; 
        
        public DeckOfCards()
        {
            deck = new Card[NUMBER_OF_DICES];
        }

        public Card[] getDeck { get { return deck; } }

        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };                   
                }

            }

            MugShuffler();

        }

        public void MugShuffler ()
        {
            Random rand = new Random();
            Card temp; 

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
