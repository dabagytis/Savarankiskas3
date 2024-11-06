using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_4.Models
{
    public class Dviratis : TransportoPriemone
    {
        public Dviratis(int greitis) : base(greitis)
        {

        }

        public int ApskaiciuotiKelionesLaika(int atstumas)
        {
            int laikas = 0;
            if(Greitis <= 20)
            {
                laikas = atstumas / Greitis;
                return laikas;
            }
            else
            {
                laikas = atstumas / 20;
                return laikas;
            }
        }
    }
}
