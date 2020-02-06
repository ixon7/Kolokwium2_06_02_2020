using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_06_02_2020
{
    public class Bateria : IZasilanie
    {
        private int Pojemnosc { get; set; }
        public Bateria(int pojemnosc)
        {
            pojemnosc = Pojemnosc;
        }
        public void used()
        {
            //Pojemnosc - 100;
        }
        public void Zasilaj(int energia)
        {
            throw new NotImplementedException();
        }
        public void Zasilanie(int energia)
        {
            if (Pojemnosc>0)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Brak zasilania");
            }
        }
        Bateria bateria1 = new Bateria(1000);
        
    }
}
