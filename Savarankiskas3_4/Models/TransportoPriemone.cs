using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_4.Models
{
    public class TransportoPriemone
    {
        public int Greitis { get; set; }

        public TransportoPriemone(int greitis)
        {
            Greitis = greitis;
        }
    }
}
