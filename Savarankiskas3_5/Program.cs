using Savarankiskas3_5.Core.Contracts;
using Savarankiskas3_5.Core.Models;
using System;

namespace Savarankiskas3_5;

public class Program
{
    public static void Main(string[] args)
    {
        string fileLocation = "Duomenys.txt";
        IFailoSkaitymas failoSkaitymas = new FailoSkaitymas(fileLocation);
        IDuomenuServisas duomenuServisas = new DuomenuServisas(failoSkaitymas);

        List<string> duomenys = failoSkaitymas.SkaitytiDuomenis(fileLocation);
        Console.WriteLine($"Vidutinis zmoniu amzius dokumente: {Math.Round(duomenuServisas.ApskaiciuotiVidutiniAmziu(duomenys),2)}");
    }
}