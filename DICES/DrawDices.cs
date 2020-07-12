using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DICES
{
    //rysowanie obszaru kości
    class DrawDices
    {
        //obszar kości 5, aby w miarę był kwadrat i mieścił się napis wartości
        public static void DrawDiceOutline(int xcord, int ycord)
        {

            int x = xcord * 8;
            int y = ycord;
                        
            Console.SetCursorPosition(x, y);            
            Console.Write(" _______\n");

            // pętelka do rysowania kości i dolnej krawędzi
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 4)
                    Console.WriteLine("|       | "); // boki
                else
                    Console.WriteLine("|_______| "); // dół
            }
        }

        // wpisanie wartości do obszaru kości
         public static void DrawDiceValue(Dice dice, int xcord, int ycord)
        {

            string MyValue = " ";
            int x = xcord * 8;
            int y = ycord * 1;            

            switch(dice.MyValue)
            {
                case Dice.VALUE.ONE:
                    Console.Write("ONE");
                    break;
                case Dice.VALUE.TWO:
                    Console.Write("TWO");
                    break;
                case Dice.VALUE.THREE:
                    Console.Write("THREE");
                    break;
                case Dice.VALUE.FOUR:
                    Console.Write("FOUR");
                    break;
                case Dice.VALUE.FIVE:
                    Console.Write("FIVE");
                    break;
                case Dice.VALUE.SIX:
                    Console.Write("SIX");
                    break;
                case Dice.VALUE.SEVEN:
                    Console.Write("SEVEN");
                    break;
                case Dice.VALUE.EIGHT:
                    Console.Write("EIGHT");
                    break;
                case Dice.VALUE.NINE:
                    Console.Write("NINE");
                    break;
                case Dice.VALUE.TEN:
                    Console.Write("TEN");
                    break;
            }        
            
            // rysowanie kości na ekranie konsoli
            Console.SetCursorPosition(x + 2, y + 3);
            Console.Write(dice.MyValue); 

        } 
    }
}
