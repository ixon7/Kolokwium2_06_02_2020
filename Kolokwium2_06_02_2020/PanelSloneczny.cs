using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Kolokwium2_06_02_2020
{
    public class PanelSloneczny : IZasilanie
    {
        public static DateTime Now { get; set; }
        public void Zasilaj(int energia)
        {
            throw new NotImplementedException();
        }
        public void Zasilanie(int energia)
        {
            DateTime localDate = DateTime.Now;
                if (energia < 100 && localDate.Hour >= 06 && localDate.Hour <= 18)
                {
                    Console.WriteLine("Ok");
                }
        }
        PanelSloneczny panel1 = new PanelSloneczny();
    }
}
