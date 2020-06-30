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
            int number = rnd.Next(5, 10);
            Console.WriteLine(number);

            int[] numbers = new int[10];
            for (int i = 0; i <numbers.Length; i++ )
            {
                numbers[i] = rnd.Next(1, 50);
            }

            foreach ( var nr in numbers)
            {
                Console.Write(nr + " ");
            }

        }
    }

}

