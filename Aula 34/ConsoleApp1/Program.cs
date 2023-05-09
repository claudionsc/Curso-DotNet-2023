using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerosFibo = new List<int> { 1, 1 };

            while (numerosFibo.Count <= 30)
            {
            var numeroAnterior1 = numerosFibo[numerosFibo.Count - 1];
            var numeroAnterior2 = numerosFibo[numerosFibo.Count - 2];

                var item = numeroAnterior1 + numeroAnterior2;

            numerosFibo.Add(item);

                Console.WriteLine(item);

            }



        }
    }
}