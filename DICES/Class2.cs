using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class Throws : Dice
    {
        const int NUMBER_OF_DICES = 5;
        private Dice[] mug; 
        
        public Throws()
        {
            mug = new Dice[NUMBER_OF_DICES];
        }

        public Dice[] GetDices { get { return mug; } }

        public void setUpMug ()
        {
            int i = 0;
            foreach (DICECOLOR c in Enum.GetValues(typeof(DICECOLOR)))
            {
                foreach (DICETHROW t in Enum.GetValues(typeof(DICETHROW)))
                {
                    mug[i] = new Dice { Color = c, Throw = t };
                }
                
            }

        }

    }
}
