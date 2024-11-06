using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_3.Models
{
    public class PilnasEtatas: Darbuotojas
    {
        public PilnasEtatas(string vardas, decimal atlyginimas) : base(vardas, atlyginimas)
        {

        }

        public decimal GautiMetiniAtlyginima()
        {
            decimal metinis = Atlyginimas * 12;
            return metinis;
        }
    }
}
