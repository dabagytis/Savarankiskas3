using Savarankiskas3_1.Models;
using System;

namespace Savarankiskas3_1;

public class Program
{
    public static void Main(string[] args)
    {
        Knyga knyga = new Knyga();

        Console.WriteLine("Iveskite knygos pavadinima:");
        string pavadinimas = Console.ReadLine();
        Console.WriteLine("Iveskite knygos puslapiu skaiciu:");
        int puslapiuSkaicius = int.Parse(Console.ReadLine());
        Console.WriteLine();

        knyga = new Knyga(pavadinimas, puslapiuSkaicius);
        Console.WriteLine("Rezultatas:");
        knyga.KlasifikuotiKnyga();
    }
}