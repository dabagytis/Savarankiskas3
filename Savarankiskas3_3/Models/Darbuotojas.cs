using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_3.Models
{
    public class Darbuotojas
    {
        public string Vardas { get; set; }
        public decimal Atlyginimas { get; set; }

        public Darbuotojas(string vardas, decimal atlyginimas)
        {
            Vardas = vardas;
            Atlyginimas = atlyginimas;
        }
    }
}
