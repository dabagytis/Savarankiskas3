using Savarankiskas3_2.Models;
using System;

namespace Savarankiskas3_2;

public class Program
{
    public static void Main(string[] args)
    {
        Studentas studentas = new Studentas();

        Console.WriteLine("Iveskite studento varda:");
        string vardas = Console.ReadLine();
        Console.WriteLine("Iveskite studento pazymi:");
        int pazymys = int.Parse(Console.ReadLine());
        Console.WriteLine();
        studentas = new Studentas(vardas, pazymys);
        studentas.NustatytiIvertinima();
    }
}