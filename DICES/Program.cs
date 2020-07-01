﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace DICES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(65, 40);
            Console.BufferWidth = 65;
            Console.BufferHeight = 40;            
            Console.Title = "POKER DICE GAME";
            ShuffleOfDices dd = new ShuffleOfDices();
            bool quit = false;

            while (!quit)
            {
                dd.ThrowDice();

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

        }
        
    } 

}

