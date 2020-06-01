using System;
using System.Net.Http.Headers;

namespace DICES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Kościany Poker ver.0.1 - GitHub 1st Project Pull");
            Console.WriteLine("Poker - układ rzutów jak w klasycznym Pokerze Omaha - do 5ciu kości, rzut - blokada - rzut.");
            Console.WriteLine("Po rundzie pierwszej wymiana, od 1 do 5 kości, runda druga rzutów - sprawdzenie układu.");
            Console.WriteLine("Jezu, poker kościany w jaki gra się pod celą na Monte albo był w pierwszym Wiedźmaku");
            Console.WriteLine("Przewaga dwóch zwycięstw, gra do trzech rund, porównanie z komputerem po każdej rundzie");
            Console.ReadKey();
            Console.WriteLine("Class - Dice. Każdy obiekt będzie dziedziczył po klasie głównej - tylko z innym atrybutem: 1,2,3,4,5");
            Console.WriteLine("Class Dice -> Dice1: wynik rzutu (1,2,3,4,5,6) -> Dice2: wynik rzutu itd. itd.");
            Console.WriteLine("Metoda Losowania rzutu dla kości - nie ma znaczenia czy user czy comp. - metoda losowania rzutu");
            Console.WriteLine("Kto zaczyna grę? Określenie czy losowanie? Gra z drugim użytkownikiem tzw. Hot Seats?");
            Console.WriteLine("Zapisujemy wynik do tablicy 1dno wymiarowej pięcoelementowej - kości jest 5.");
            Console.WriteLine("Z góry określamy możliwe argumenty dla klasy Dice - 1,2,3,4,5,6 - tyle jest możliwych wyników rzutu");
            Console.WriteLine("Z góry określamy możliwe miejsca dla wyniku - 5 - tyle ile kart w Pokerze Omaha jest na ręku.");
            Console.ReadKey();
         }
    }
}
