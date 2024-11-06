using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_1.Models
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public int PuslapiuSkaicius { get; set; }

        public Knyga()
        {

        }

        public Knyga(string pavadinimas, int puslapiuSkaicius)
        {
            Pavadinimas = pavadinimas;
            PuslapiuSkaicius = puslapiuSkaicius;
        }

        public void KlasifikuotiKnyga()
        {
            string tipas = "";
            if (PuslapiuSkaicius < 100)
            {
                tipas = "trumpa";
                Console.WriteLine($"Knyga \"{Pavadinimas}\" yra {tipas}");
            }
            else if (PuslapiuSkaicius >= 100 && PuslapiuSkaicius <= 300)
            {
                tipas = "vidutine";
                Console.WriteLine($"Knyga \"{Pavadinimas}\" yra {tipas}");
            }
            else
            {
                tipas = "ilga";
                Console.WriteLine($"Knyga \"{Pavadinimas}\" yra {tipas}");
            }
        }
    }
}
