using System;

namespace ConsoleApp1
{
    public static class StrzalBota
    {
        public static bool CzyGraZakonczona(Plansza plansza)
        {
            for (int i = 0; i < plansza.wielkosc; i++)
            {
                for (int j = 0; j < plansza.wielkosc; j++)
                {
                    if (plansza.plansza[i, j].stan == "zajęte")
                        return false;
                }
            }
            return true;
        }

        public static void BotStrzal(Plansza plansza)
        {
            Random rand = new Random();
            int x, y;

            do
            {
                x = rand.Next(0, plansza.wielkosc);
                y = rand.Next(0, plansza.wielkosc);
            }
            while (plansza.plansza[x, y].stan == "trafione" || plansza.plansza[x, y].stan == "nietrafione");

            if (plansza.strzal(x, y))
            {
                Console.WriteLine($"Bot trafił w ({x}, {y})!");
            }
            else
            {
                Console.WriteLine($"Bot chybił w ({x}, {y}).");
            }
        }
    }
}
