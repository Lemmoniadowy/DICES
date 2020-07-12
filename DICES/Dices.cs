using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DICES
{
    //klasa Dice
    class Dice
    {        
        // values set 
        public enum VALUE
        {
            ONE = 1, 
            TWO, 
            THREE, 
            FOUR, 
            FIVE, 
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN
            
        }
        
        // get set properties 
        public VALUE MyValue { get; set; }
        public static Dice FourKind { get; protected set; }
        public static Dice FullHouse { get; protected set; }
        public static Dice Straight { get; protected set; }
        public static Dice ThreeOfKind { get; protected set; }
        public static Dice TwoPairs { get; protected set; }
        public static Dice OnePair { get; protected set; }
        public static Dice Nothing { get; protected set; }
    }
}
