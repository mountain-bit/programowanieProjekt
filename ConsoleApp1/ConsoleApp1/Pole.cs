using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pole
    {
        public int x;
        public int y;
        public string stan; //puste , zajęte, trafione, nietrafione

        public Pole(int x, int y)
        {
            this.x = x;
            this.y = y;
            stan = "puste";
        }

        public void ZmienStan(string stan)
        {
            if (stan == "puste" || stan == "zajęte" || stan == "trafione" || stan == "nietrafione")
                this.stan = stan;
        }


        public bool przyjecieStrzaly()
        {

            if (stan == "zajęte")
            {
                stan = "trafione";
                return true;
            }
            else
            {
                stan = "nietrafione";
                return false;
            }

        }


    }
}
