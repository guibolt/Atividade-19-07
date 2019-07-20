using System;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> NumP = new List<uint>();
            List<uint> NumI = new List<uint>();

            for (uint i = 1; i <= 100; i++)
            {
                if (i % 2 ==0)
                {
                    NumP.Add(i);
                }
                else
                {
                    NumI.Add(i);
                }
            }
            Console.WriteLine("Numeros Pares:");
            foreach (var pares in NumP)
            {
                Console.Write($"{pares} ");
            }
            Console.WriteLine("");
            Console.WriteLine("Numeros Impares:");
            foreach (var impares in NumI)
            {
                Console.Write($"{impares} ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Setimo numero par: {NumP[6]}");
            Console.WriteLine($"Vigesimo numero impar: {NumI[19]}");
            Mudarpar(NumP);
            Mudarimpar(NumI);
        }
        static void Mudarpar(List<uint> par)
        {
            for (uint i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    par.Add(i - 1);
                    par.Remove(i);
                }
            }
        }
        static void Mudarimpar(List<uint> impar)
        {
            for (uint i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    impar.Add(i + 1);
                    impar.Remove(i);
                }
            }
        }
    }
}
