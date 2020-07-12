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
        //obszar kości 5, aby w miarę był kwadrat i mieścił się napis wartości
        public static void DrawDiceOutline(int xcord, int ycord)
        {
            
            int x = xcord * 6;
            int y = ycord;
                        
            Console.SetCursorPosition(x, y);            
            Console.Write(" ______\n");

            // pętelka do rysowania kości i dolnej krawędzi
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 5)
                    Console.WriteLine("|      | "); // boki
                else
                    Console.WriteLine("|______| "); // dół
            }
        }

        // wpisanie wartości do obszaru kości
        public static void DrawDiceValue(Dice dice, int xcord, int ycord)
        {

            string MyValue = " ";
            int x = xcord;
            int y = ycord;            

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
                
            }        
            
            // rysowanie kości na ekranie konsoli
            Console.SetCursorPosition(x + 2, y + 3);
            Console.Write(dice.MyValue); 

        } 
    }
}
