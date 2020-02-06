using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_06_02_2020
{
    public class Skladnik
    {
        public int Weglowodany { get; set; }
        public int Tluszcz { get; set; }
        public int Sol { get; set; }

        public Skladnik(int weglowodany, int tluszcz, int sol)
        {
            Weglowodany = weglowodany;
            Tluszcz = tluszcz;
            Sol = sol;
        }
    }
}
