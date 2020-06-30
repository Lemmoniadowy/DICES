﻿using System;
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

        public void setUpMug()
        {
            int i = 0;
            foreach (SUIT c in Enum.GetValues(typeof(SUIT)))
            {
                foreach (THROW t in Enum.GetValues(typeof(THROW)))
                {
                    mug[i] = new Dice { MyColor = c, MyThrow = t };
                    i++;
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
                    temp = mug[i];
                    mug[i] = mug[secondDiceIndex];
                    mug[secondDiceIndex] = temp;
                }
            }
        }

    }
}
