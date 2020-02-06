using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_06_02_2020
{
    public class Hex
    {
        public string Kod { get; set; }
        public string R { get; set; }
        public string G { get; set; }
        public string B { get; set; }

        public Hex(string kod)
        {
            Kod = kod;
        }
        public void Deconstruct(out string r, out string g, out string b)
        {
            r = R;
            g = G;
            b = B;
        }
        public void Deconstruct(out int j, out int d, out int t)
        {
            j = Convert.ToInt32(R);
            d = Convert.ToInt32(G);
            t = Convert.ToInt32(B);
        }
    }
}
