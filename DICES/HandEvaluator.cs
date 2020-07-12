using System;
using System.Collections.Generic;
using System.Text;

namespace DICES
{
    public enum Hand
    {
        Nothing,
        OnePair,
        TwoPairs,
        ThreeKind,
        Straight,
        FullHouse,
        FourKind
    }

    public struct HandValue
    {
        public int Total { get; set; }
        public int HighDice { get; set; }
    }

    class HandEvaluator : Dice
    {
        private int oneSum;
        private int twoSum;
        private int threeSum;
        private int fourSum;
        private int fiveSum;
        private int sixSum;
        private int sevenSum;
        private int eightSum;
        private int nineSum;
        private int tenSum;
        private Dice[] dices;
        private HandValue handValue;

        public HandEvaluator (Dice[] sortedHand)
        {
            oneSum = 0;
            twoSum = 0;
            threeSum = 0;
            fourSum = 0;
            fiveSum = 0;
            sixSum = 0;
            sevenSum = 0;
            eightSum = 0;
            nineSum = 0;
            tenSum = 0;
            dices = new Dice[5];
            handValue = new HandValue();
        }

        public HandValue HandValues
        {
            get { return handValue; }
            set { handValue = value; }
        }

        public Dice [] Dices
        {
            get { return dices; }
            set
            {
                dices[0] = value[0];
            }

        }
    }
}
