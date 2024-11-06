using Savarankiskas3_4.Models;
using System;

namespace Savarankiskas3_4;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pasirinkite transporto priemones tipa:");
        Console.WriteLine("1. Automobilis");
        Console.WriteLine("2. Dviratis");
        int parinktis = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Iveskite greiti (km/h):");
        int greitis = int.Parse(Console.ReadLine());
        Console.WriteLine("Iveskite keliones atstuma (km):");
        int atstumas = int.Parse(Console.ReadLine());

        switch (parinktis)
        {
            case 1:
                Automobilis automobilis = new Automobilis(greitis);
                Console.WriteLine($"Vaziuojant automobiliu, keliones laikas yra {automobilis.ApskaiciuotiKelionesLaika(atstumas)}val");
                break;

            case 2:
                Dviratis dviratis = new Dviratis(greitis);
                Console.WriteLine($"Vaziuojant dviraciu, keliones laikas yra {dviratis.ApskaiciuotiKelionesLaika(atstumas)}val");
                break;
        }
    }
}