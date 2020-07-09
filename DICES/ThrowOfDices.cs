using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class DrawDices
    {
        public static void DrawDiceCubeOutline(int xcord, int ycord)
        {
            
            Console.ForegroundColor = ConsoleColor.White;

            int x = xcord * 12;
            int y = ycord;
                        
            Console.SetCursorPosition(x, y);
            Console.Write(" __________\n");

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                    Console.WriteLine("|          |");
                else
                    Console.WriteLine("|__________|");
            }
        }

        public static void DrawDiceSuitValue(Dice card, int xcord, int ycord)
        {       
        
            char cardValue = ' ';
            int x = xcord * 12;
            int y = ycord;            

            /* switch(card.MySuit)
            {
                case Card.SUIT.RED:                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.GREEN:                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Card.SUIT.YELLOW:                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Card.SUIT.BLUE:                                        
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Card.SUIT.MAGENTA:                   
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                
            }
            */
                        
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(Dice.VALUE); 

        }
    }
}
