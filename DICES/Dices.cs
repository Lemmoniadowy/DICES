using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dices
{
    class Dice
    {
        public enum DICECOLOR
        {
            WHITE,
            BLACK,
            ORANGE,
            PURPULE,
            GREEN,
        }
        public enum DICETHROW
        {
            ONE = 1, 
            TWO, 
            THREE, 
            FOUR, 
            FIVE, 
            SIX
        }
        public DICECOLOR Color { get; set; }
        public DICETHROW Throw { get; set; }
    }
}
