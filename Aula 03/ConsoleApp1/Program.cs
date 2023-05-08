// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //coleção List
            Console.WriteLine("Hello, World");

            Carro carro1 = new Carro("Carro 1 ========");
            
            Carro carro2 = new Carro("Sou o carro 2");

            Carro carro3 = new Carro("Carro 3 ----------");

            Console.WriteLine(carro1);
            Console.WriteLine(carro2);
            Console.WriteLine(carro3);

            //Console.WriteLine(carro1.DigaSeuNome("Carro 1"));
            //Console.WriteLine(carro2.DigaSeuNome());
            //Console.WriteLine(carro2.DataRegistro());
            //Console.WriteLine(carro3.DigaSeuNome("Carro 3"));

            Console.Read();

        }

        class Carro
        {
            //construtor, um método que é chamado sempre que a classe
            //é instanciada

            private string nome;
            public Carro(string Nome)
            {
                nome = Nome;
            }

            public Carro()
            {
                
            }


            //override serve para todas as classes

            public override string ToString()
            {
                return string.Format("Eu sou o carro {0} e fui registrado em {1}", this.nome, this.DataRegistro());
            }

            //sobrecarga de método
            public string DigaSeuNome()
            {
                return nome;
            }
            public string DigaSeuNome(string Nome) 
            {
                return Nome;
            }

            public DateTime DataRegistro()
            {
                return DateTime.Now;
            }
        }
    }
}
