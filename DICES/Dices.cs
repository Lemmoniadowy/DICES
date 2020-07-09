using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class Dice
    {        
        public enum VALUE
        {
            ONE, 
            TWO, 
            THREE, 
            FOUR, 
            FIVE, 
            SIX
        }      
        public VALUE MyValue { get; set; }
    }
}
