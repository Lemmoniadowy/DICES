using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    //Klasa MugOfDices musi mieć dostęp do Dice
    class MugOfDices : Dice
    {
        //10 kości bo 2 graczy po 5 kości
        const int NUMBER_OF_DICES = 10;
        private Dice[] deck; 
        
        //konstruktor kubka
        public MugOfDices()
        {
            deck = new Dice[NUMBER_OF_DICES];
        }

        //pobieramy kości i tworzymy decka
        public Dice[] getDeck { get { return deck; } }

        //ustawiamy decka
        public void setUpDeck()
        {
            int i = 0;            
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Dice { MyValue = v };
                    i++;
                }            
        // losujemy w tej samej public void (pobieramy i losujemy)
         MugShuffler();

        }
        
        // miksowanie, ustawiamy temp`a i mielimy układ 100 razy
         public void MugShuffler()
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

