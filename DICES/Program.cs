﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DICES
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetWindowSize(65, 40);
            Console.BufferWidth = 65;
            Console.BufferHeight = 40;
            Console.Title = "POKER DICES GAME";
            DrawDices.DrawDiceOutline(0, 0);

            Dice dice = new Dice();
            dice.MyValue = Dice.VALUE.ONE;
            DrawDices.DrawDiceValue(dice, 0, 0);

            Console.ReadKey();
            /* Console.BackgroundColor= ConsoleColor.DarkGreen;
            Console.SetWindowSize(65, 40);
            Console.BufferWidth = 65;
            Console.BufferHeight = 40;            
            Console.Title = "POKER DICES GAME";
            Deal = new Dice ();
            bool quit = false;

            while (!quit)
            {
                dd.Deal();

                char selection = ' ';
                while (!selection.Equals('Y') && !selection.Equals('N'))
                {
                    Console.WriteLine("Play again? Y-N");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (selection.Equals('Y'))
                        quit = false;
                    else if (selection.Equals('N'))
                        quit = true;
                    else
                        Console.WriteLine("Invalid Selection. Try again.");
                    
                }
            }

            Console.ReadKey();
            */
        }
        
    } 

}

