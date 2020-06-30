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
            Console.ReadKey();
        }

        /*static void Opis()
        {
            Console.WriteLine("Random Number Game");
            Console.WriteLine("Trolololo! Sync check.");

        }   
        static void Main(string []args)
        {
            Opis();

            Random rnd = new Random();

            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            Console.WriteLine("Dice 1: " + dice1);
            Console.WriteLine("Dice 2: " + dice2);

            if (dice1 > dice2)
            {
                Console.WriteLine("Dice 1 wins!");
            }
            else if (dice1 < dice2)
            {
                Console.WriteLine("Dice 2 wins!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }


        }*/
    } 

}

