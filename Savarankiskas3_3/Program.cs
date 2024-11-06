using Savarankiskas3_3.Models;
using System;

namespace Savarankiskas3_3;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iveskite darbuotojo varda:");
        string vardas = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Iveskite darbuotojo menesio atlyginima:");
        decimal atlyginimas = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Nurodykite darbuotojo tipa:");
        Console.WriteLine("1. Pilnas etatas");
        Console.WriteLine("2. Puse etato");
        int parinktis = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (parinktis)
        {
            case 1:
                PilnasEtatas pilnasEtatas = new PilnasEtatas(vardas, atlyginimas);
                Console.WriteLine($"Darbuotojas {vardas} dirba pilnu etatu, jo metinis atlyginimas {pilnasEtatas.GautiMetiniAtlyginima()}eur");
                break;

            case 2:
                PuseEtato puseEtato = new PuseEtato(vardas, atlyginimas);
                Console.WriteLine($"Darbuotojas {vardas} dirba puse etato, jo valandinis atlyginimas {puseEtato.GautiValandiniAtlyginima()}eur");
                break;
        }
    }
}