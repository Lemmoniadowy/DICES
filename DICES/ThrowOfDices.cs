using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class ThrowOfDices : Dice
    {
        public static void DrawCubeOutline(int xcord, int ycord)
        {

            CodePagesEncodingProvider.Instance.GetEncoding(437);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

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

        public static void DrawDiceColorThrow(Dice dice, int xcord, int ycord)
        {

            CodePagesEncodingProvider.Instance.GetEncoding(437);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            char cubeColor = ' ';
            int x = xcord * 12;
            int y = ycord;            

            /* switch(dice.MyColor)
            {
                case Dice.SUIT.HEARTH:
                    dice.MyColor = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Dice.SUIT.GREEN:
                    dice.MyColor = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Dice.SUIT.YELLOW:
                    dice.MyColor = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Dice.SUIT.BLUE:
                    dice.MyColor = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Dice.SUIT.MAGENTA:
                    dice.MyColor = Encoding.GetEncoding(437).GetChars(new byte[] { 7 })[0];
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                
            }
            */
            
            Console.SetCursorPosition(x + 3, y + 3);
            /* Console.Write(dice.MyColor); */
            Console.SetCursorPosition(x + 4, y + 7);
            /* Console.Write(dice.MyThrow); */

        }
    }
}
