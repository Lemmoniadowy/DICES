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

    class HandEvaluator
    {

    }
}
