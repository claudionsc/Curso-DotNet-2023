using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os números a serem somados");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( $"O resultado da soma é {Soma(numero1, numero2)}" );

            Console.WriteLine("Aperte enter para finalizar o programa");

            Console.ReadLine();
        }

        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
