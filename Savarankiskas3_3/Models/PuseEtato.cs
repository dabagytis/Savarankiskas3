using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_3.Models
{
    public class PuseEtato: Darbuotojas
    {
        public PuseEtato(string vardas, decimal atlyginimas) : base(vardas, atlyginimas)
        {

        }

        public decimal GautiValandiniAtlyginima()
        {
            decimal valandinis = Atlyginimas / 160;
            return valandinis;
        }
    }
}
