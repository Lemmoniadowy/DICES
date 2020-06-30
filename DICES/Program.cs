using System;

namespace RandomDices
{
    class Program
    {
        static void Opis()
        {
            Console.WriteLine("Random Number Game");

        }   
        static void Main(string []args)
        {
            Opis();

            Random rnd = new Random();

            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);


        }
    }

}

