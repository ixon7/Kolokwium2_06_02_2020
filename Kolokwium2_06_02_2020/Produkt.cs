using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolokwium2_06_02_2020
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public List<Skladnik> Skladniki { get; set; }
        List<Produkt> Produkty = new List<Produkt>();
        public Produkt(string nazwa, List<Skladnik> sklad)
        {
            Nazwa = nazwa;
            Skladniki = sklad;
        }
        //Produkt ciasto = new Produkt("Babeczka", );
        PanelSloneczny panel1 = new PanelSloneczny();
    }
}
