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
            
            Console.ForegroundColor = ConsoleColor.White;

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

        public static void DrawDiceValue(Dice card, int xcord, int ycord)
        {       
        
            char diceValue = ' ';
            int x = xcord * 12;
            int y = ycord;            

            switch(card.MyValue)
            {
                case Dice.VALUE.ONE:                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Dice.VALUE.TWO:                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Dice.VALUE.THREE:                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Dice.VALUE.FOUR:                                        
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Dice.VALUE.FIVE:                   
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                
            }
            
                        
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(Dice.MyValue); 

        } 
    }
}
