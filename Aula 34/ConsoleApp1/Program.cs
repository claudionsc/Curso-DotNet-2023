using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> { "<nome>", "Ana", "Felipe " };

            nomes.Add("Diogo");
            nomes.Add("Maria");
            nomes.Add("Ana");

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome.ToUpper()}");
            }
            var index = nomes.IndexOf("Diogo");
            Console.WriteLine($"Encontrei o Diogo na posição {index} ");
        }
    }
}