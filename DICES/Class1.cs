using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class Dice
    {
        public enum DICETHROW
        {
            ONE = 1, TWO, THREE, FOUR, FIVE, SIX
        }
        public DICETHROW Throw { get; set; }
    }
}
