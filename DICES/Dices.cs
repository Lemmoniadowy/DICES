using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    //klasa Dice
    class Dice
    {        
        // values set 
        public enum VALUE
        {
            ONE, 
            TWO, 
            THREE, 
            FOUR, 
            FIVE, 
            SIX
        }
        
        // get set properties 
        public VALUE MyValue { get; set; }
    }
}
