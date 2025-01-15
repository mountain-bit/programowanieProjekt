using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Plansza
    {
        public int wielkosc;
        public Pole[,] plansza;
        public Plansza(int wielkosc)
        {
            this.wielkosc = wielkosc;

            plansza = new Pole[wielkosc, wielkosc];

            for (int i = 0; i < wielkosc; i++)
            {
                for (int j = 0; j < wielkosc; j++)
                {
                    plansza[i, j] = new Pole(i, j);
                }
            }


            Random rand = new Random();
            int iloscStatkow = 15;

            for (int i = 0; i < iloscStatkow; i++)
            {
                int x = rand.Next(0, wielkosc - 1);
                int y = rand.Next(0, wielkosc - 1);

                if (plansza[x, y].stan.Equals("zajęte"))
                {
                    i--;
                }
                else
                {
                    if (x - 1 >= 0 && plansza[x - 1, y].stan.Equals("zajęte"))
                    {
                        i--;
                        continue;
                    }
                    else if (x + 1 < wielkosc && plansza[x + 1, y].stan.Equals("zajęte"))
                    {
                        i--;
                        continue;
                    }
                    else if (y - 1 >= 0 && plansza[x, y - 1].stan.Equals("zajęte"))
                    {
                        i--;
                        continue;
                    }
                    else if (y + 1 < wielkosc && plansza[x, y + 1].stan.Equals("zajęte"))
                    {
                        i--;
                        continue;
                    }
                    plansza[x, y].stan = "zajęte";
                }
            }




        }

        public void wyswietl()
        {
            for(int j= 0; j < wielkosc; j++)
            {
                Console.Write(" "+j );
            }
            Console.WriteLine();
            for (int i = 0; i < wielkosc; i++)
            {
                Console.Write(i);
                for (int j = 0; j < wielkosc; j++)
                {
                  
                    if (plansza[i, j].stan.Equals("zajęte"))
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("O" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (plansza[i, j].stan.Equals("trafione"))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("X" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (plansza[i, j].stan.Equals("nietrafione"))
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write("x" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("~" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }


        public void wyswietlDlaWrog()
        {
            for (int j = 0; j < wielkosc; j++)
            {
                Console.Write(" " + j);
            }
            Console.WriteLine();
            for (int i = 0; i < wielkosc; i++)
            {
                Console.Write(i);
                for (int j = 0; j < wielkosc; j++)
                {

                     if (plansza[i, j].stan.Equals("trafione"))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("X" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (plansza[i, j].stan.Equals("nietrafione"))
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write("x" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("~" + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }



        public bool strzal(int x, int y)
        {
            if (plansza[x, y].przyjecieStrzaly())
            {
                if (x - 1 >= 0)
                {
                    plansza[x - 1, y].stan = "nietrafione";
                }
                if (x + 1 < wielkosc)
                {
                    plansza[x + 1, y].stan = "nietrafione";
                }
                if (y - 1 >= 0)
                {
                    plansza[x, y - 1].stan = "nietrafione";
                }
                if (y + 1 < wielkosc)
                {
                    plansza[x, y + 1].stan = "nietrafione";
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
