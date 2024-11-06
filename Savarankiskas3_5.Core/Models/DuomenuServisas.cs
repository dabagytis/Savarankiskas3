using Savarankiskas3_5.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_5.Core.Models
{
    public class DuomenuServisas : IDuomenuServisas
    {
        private IFailoSkaitymas failoSkaitymas;

        public DuomenuServisas(IFailoSkaitymas failoSkaitymas)
        {
            this.failoSkaitymas = failoSkaitymas;
        }
        public double ApskaiciuotiVidutiniAmziu(List<string> duomenys)
        {
            List<double> duomenysSkaiciai = duomenys.ConvertAll(double.Parse);
            double vidurkis = duomenysSkaiciai.Average();
            return vidurkis;
        }
    }
}
