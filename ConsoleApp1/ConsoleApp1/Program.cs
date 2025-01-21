using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze w statki!");
            Console.Write("Podaj rozmiar planszy (np. 10): ");
            int wielkoscPlanszy = int.Parse(Console.ReadLine());

            Plansza graczPlansza = new Plansza(wielkoscPlanszy);
            Plansza botPlansza = new Plansza(wielkoscPlanszy);

            Console.WriteLine("\nTwoja plansza:");
            graczPlansza.wyswietl();

            while (true)
            {
                Console.WriteLine("\nTwoja tura:");
                Console.Write("Podaj współrzędne strzału (x y): ");
                string[] input = Console.ReadLine().Split(' ');
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                if (x < 0 || y < 0 || x >= wielkoscPlanszy || y >= wielkoscPlanszy)
                {
                    Console.WriteLine("Nieprawidłowe współrzędne. Spróbuj ponownie.");
                    continue;
                }

                if (botPlansza.strzal(x, y))
                {
                    Console.WriteLine("Trafiłeś!");
                }
                else
                {
                    Console.WriteLine("Pudło!");
                }

                Console.WriteLine("Plansza przeciwnika:");
                botPlansza.wyswietlDlaWrog();

                if (StrzalBota.CzyGraZakonczona(botPlansza))
                {
                    Console.WriteLine("Gratulacje! Wygrałeś!");
                    break;
                }

                Console.WriteLine("\nTura bota:");
                StrzalBota.BotStrzal(graczPlansza);

                Console.WriteLine("Twoja plansza:");
                graczPlansza.wyswietl();

                if (StrzalBota.CzyGraZakonczona(graczPlansza))
                {
                    Console.WriteLine("Przegrałeś! Bot zatopił wszystkie twoje statki.");
                    break;
                }
            }

            Console.WriteLine("Dziękujemy za grę!");
        }
    }
}
