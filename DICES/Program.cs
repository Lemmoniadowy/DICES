using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DICES
{
    class Program
    {
        static void Main(string []args)
        {
           
            ThrowOfDices.DrawCubeOutline(0, 0);

            Dice dice = new Dice();
            dice.MyColor = Dice.SUIT.GREEN;
            dice.MyThrow = Dice.THROW.TWO;
            ThrowOfDices.DrawDiceColorThrow(dice, 0, 0);

            Console.ReadKey();
        }
        
    } 

}

