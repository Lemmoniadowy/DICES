using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    //rysowanie obszaru kości
    class DrawDices
    {
        public static void DrawDiceOutline(int xcord, int ycord)
        {
            
            int x = xcord * 5;
            int y = ycord;
                        
            Console.SetCursorPosition(x, y);
            Console.Write(" ______\n");

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 4)
                    Console.WriteLine("|      |");
                else
                    Console.WriteLine("|______|");
            }
        }

        public static void DrawDiceValue(Dice dice, int xcord, int ycord)
        {

            char MyValue = ' ';
            int x = xcord * 12;
            int y = ycord;            

            switch(dice.MyValue)
            {
                case Dice.VALUE.ONE:                
                    break;
                case Dice.VALUE.TWO:                    
                    break;
                case Dice.VALUE.THREE:                    
                    break;
                case Dice.VALUE.FOUR:                                        
                    break;
                case Dice.VALUE.FIVE:                   
                    break;
                case Dice.VALUE.SIX;
                    break;
                
            }            
                        
            Console.SetCursorPosition(x + 2, y + 3);
            Console.Write(dice.MyValue); 

        } 
    }
}
