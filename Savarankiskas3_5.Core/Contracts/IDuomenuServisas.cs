using Savarankiskas3_5.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_5.Core.Contracts
{
    public interface IDuomenuServisas
    {
        double ApskaiciuotiVidutiniAmziu(List<string> duomenys);
    }
}