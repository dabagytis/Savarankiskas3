using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_4.Models
{
    public class Automobilis: TransportoPriemone
    {
        public Automobilis(int greitis): base(greitis)
        {

        }

        public int ApskaiciuotiKelionesLaika(int atstumas)
        {
            int laikas = atstumas / Greitis;
            return laikas;
        }
    }
}
