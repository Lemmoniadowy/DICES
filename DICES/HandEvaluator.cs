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

        public HandEvaluator(Dice[] sortedHand)
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
            Dices = sortedHand;
            handValue = new HandValue();
        }

        public HandValue HandValues
        {
            get { return handValue; }
            set { handValue = value; }
        }

        public Dice[] Dices
        {
            get { return dices; }
            set
            {
                dices[0] = value[0];
                dices[1] = value[1];
                dices[2] = value[2];
                dices[3] = value[3];
                dices[4] = value[4];

            }

        }

        public Dice EvaluateDice()
        {
            getNumberOfDice();
            if (FourOfKind())
                return Dice.FourKind;
            else if (FullHouse())
                return Dice.FullHouse;
            else if (Straight())
                return Dice.Straight;
            else if (ThreeOfKind())
                return Dice.ThreeOfKind;
            else if (TwoPairs())
                return Dice.TwoPairs;
            else if (OnePair())
                return Dice.OnePair;


            handValue.HighDice = (int)dices[4].MyValue;
            return Dice.Nothing;
        }

        public void getNumberOfDice()
        {
            foreach (var element in Dices)
            {
                if (element.MyValue == Dice.VALUE.ONE)
                    oneSum++;
                else if (element.MyValue == Dice.VALUE.TWO)
                    twoSum++;
                else if (element.MyValue == Dice.VALUE.THREE)
                    threeSum++;
                else if (element.MyValue == Dice.VALUE.FOUR)
                    fourSum++;
                else if (element.MyValue == Dice.VALUE.FIVE)
                    fiveSum++;
                else if (element.MyValue == Dice.VALUE.SIX)
                    sixSum++;
                else if (element.MyValue == Dice.VALUE.SEVEN)
                    sevenSum++;
                else if (element.MyValue == Dice.VALUE.EIGHT)
                    eightSum++;
                else if (element.MyValue == Dice.VALUE.NINE)
                    nineSum++;
                else if (element.MyValue == Dice.VALUE.TEN)
                    tenSum++;
            }
        }

        private bool FourOfKind()
        {
            if(dices[0].MyValue == dices[1].MyValue && dices[0].MyValue == dices[2].MyValue && dices[0].MyValue == dices[3].MyValue)
            {
                handValue.Total = (int)dices[1].MyValue * 4;
                handValue.HighDice = (int)dices[4].MyValue;
                return true;
            }
            else if (dices[1].MyValue == dices[2].MyValue && dices[1].MyValue == dices[3].MyValue && dices[1].MyValue == dices[4].MyValue)
            {
                handValue.Total = (int)dices[1].MyValue * 4;
                handValue.HighDice = (int)dices[0].MyValue;
                return true;
            }

            return false;
        }

        private bool FullHouse()
        {
            if ((dices[0].MyValue == dices[1].MyValue && dices[0].MyValue == dices[2].MyValue && dices[3].MyValue == dices[4].MyValue) ||
                (dices[0].MyValue == dices[1].MyValue && dices[2].MyValue == dices[3].MyValue && dices[2].MyValue == dices[4].MyValue))
            {
                handValue.Total = (int)(dices[0].MyValue) + (int)(dices[1].MyValue) + (int)(dices[2].MyValue) +
                    (int)(dices[3].MyValue) + (int)(dices[4].MyValue);
                return true;
            }

            return false;
        }

        private bool Straight()
        {
            
            if (dices[0].MyValue + 1 == dices[1].MyValue &&
                dices[1].MyValue + 1 == dices[2].MyValue &&
                dices[2].MyValue + 1 == dices[3].MyValue &&
                dices[3].MyValue + 1 == dices[4].MyValue)
            {                
                handValue.Total = (int)dices[4].MyValue;
                return true;
            }

            return false;
        }

        private bool ThreeOfKind()
        {            
            if ((dices[0].MyValue == dices[1].MyValue && dices[0].MyValue == dices[2].MyValue) ||
            (dices[1].MyValue == dices[2].MyValue && dices[1].MyValue == dices[3].MyValue))
            {
                handValue.Total = (int)dices[2].MyValue * 3;
                handValue.HighDice = (int)dices[4].MyValue;
                return true;
            }
            else if (dices[2].MyValue == dices[3].MyValue && dices[2].MyValue == dices[4].MyValue)
            {
                handValue.Total = (int)dices[2].MyValue * 3;
                handValue.HighDice = (int)dices[1].MyValue;
                return true;
            }
            return false;
        }

        private bool TwoPairs()
        {             
            if (dices[0].MyValue == dices[1].MyValue && dices[2].MyValue == dices[3].MyValue)
            {
                handValue.Total = ((int)dices[1].MyValue * 2) + ((int)dices[3].MyValue * 2);
                handValue.HighDice = (int)dices[4].MyValue;
                return true;
            }
            else if (dices[0].MyValue == dices[1].MyValue && dices[3].MyValue == dices[4].MyValue)
            {
                handValue.Total = ((int)dices[1].MyValue * 2) + ((int)dices[3].MyValue * 2);
                handValue.HighDice = (int)dices[2].MyValue;
                return true;
            }
            else if (dices[1].MyValue == dices[2].MyValue && dices[3].MyValue == dices[4].MyValue)
            {
                handValue.Total = ((int)dices[1].MyValue * 2) + ((int)dices[3].MyValue * 2);
                handValue.HighDice = (int)dices[0].MyValue;
                return true;
            }
            return false;
        }

        private bool OnePair()
        {            
            if (dices[0].MyValue == dices[1].MyValue)
            {
                handValue.Total = (int)dices[0].MyValue * 2;
                handValue.HighDice = (int)dices[4].MyValue;
                return true;
            }
            else if (dices[1].MyValue == dices[2].MyValue)
            {
                handValue.Total = (int)dices[1].MyValue * 2;
                handValue.HighDice = (int)dices[4].MyValue;
                return true;
            }
            else if (dices[2].MyValue == dices[3].MyValue)
            {
                handValue.Total = (int)dices[2].MyValue * 2;
                handValue.HighDice = (int)dices[4].MyValue;
                return true;
            }
            else if (dices[3].MyValue == dices[4].MyValue)
            {
                handValue.Total = (int)dices[3].MyValue * 2;
                handValue.HighDice = (int)dices[2].MyValue;
                return true;
            }

            return false;
        }
    }
}
