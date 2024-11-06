using Savarankiskas3_5.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_5.Core.Models
{
    public class FailoSkaitymas : IFailoSkaitymas
    {
        private string _fileLocation;
        public FailoSkaitymas(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        public List<string> SkaitytiDuomenis(string fileLocation)
        {
            List<string> duomenys = new List<string>();
            using(StreamReader sr = new StreamReader(_fileLocation))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    string amzius = values[1];
                    duomenys.Add(amzius);
                }
            }
            return duomenys;
        }
    }
}