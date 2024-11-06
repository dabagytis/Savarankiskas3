using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3_2.Models
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int Pazymys { get; set; }

        public Studentas()
        {

        }

        public Studentas(string vardas, int pazymys)
        {
            Vardas = vardas;
            Pazymys = pazymys;
        }

        public void NustatytiIvertinima()
        {
            string statusas = "";
            if (Pazymys < 4)
            {
                statusas = "\"Neislaike\"";
                Console.WriteLine($"Studentas/e {Vardas} gavo ivertinima {Pazymys}, {statusas}.");
            }
            else if (Pazymys >= 4 && Pazymys <= 6)
            {
                statusas = "\"Patenkinamas\"";
                Console.WriteLine($"Studentas/e {Vardas} gavo ivertinima {Pazymys}, {statusas}.");
            }
            else if (Pazymys >= 7 && Pazymys <= 8)
            {
                statusas = "\"Geras\"";
                Console.WriteLine($"Studentas/e {Vardas} gavo ivertinima {Pazymys}, {statusas}.");
            }
            else
            {
                statusas = "\"Labai geras\"";
                Console.WriteLine($"Studentas/e {Vardas} gavo ivertinima {Pazymys}, {statusas}.");
            }
        }
    }
}
