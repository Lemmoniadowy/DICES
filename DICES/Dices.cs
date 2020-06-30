using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class Dice
    {
        public enum SUIT
        {
            HEARTS,
            DIAMONDS,
            CLUBS,
            SPADES,
        }
        public enum THROW
        {
            ONE = 1, 
            TWO, 
            THREE, 
            FOUR, 
            FIVE, 
            SIX
        }
        public SUIT MyColor { get; set; }
        public THROW MyThrow { get; set; }
    }
}
