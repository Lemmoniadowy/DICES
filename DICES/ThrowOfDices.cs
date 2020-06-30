using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICES
{
    class ThrowOfDices
    {
        public static void DrawCubeOutline(int xcord, int ycord)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int x = xcord * 6;
            int y = ycord;

            Console.SetCursorPosition(x, y);
            Console.Write(" ____\n");

            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 3)
                    Console.WriteLine("|    |");
                else
                    Console.WriteLine("|____|");
            }
        }

        public static void DrawDiceColorThrow(Dice dice, int xcord, int ycord)
        {
            char cubeColor = ' ';
            int x = xcord * 6;
            int y = ycord;


            switch (dice.MyColor)
            {
                case Dice.SUIT.HEARTS:
                    cubeColor = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Dice.SUIT.DIAMONDS:
                    cubeColor = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Dice.SUIT.CLUBS:
                    cubeColor = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Dice.SUIT.SPADES:
                    cubeColor = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
        }
    }
}
