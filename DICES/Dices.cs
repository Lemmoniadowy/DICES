using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class Card
    {
        public enum SUIT
        {
            RED,
            GREEN,
            YELLOW,
            BLUE,
            MAGENTA,
        }
        public enum VALUE
        {
            ONE, 
            TWO, 
            THREE, 
            FOUR, 
            FIVE, 
            SIX
        }
        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
    }
}
