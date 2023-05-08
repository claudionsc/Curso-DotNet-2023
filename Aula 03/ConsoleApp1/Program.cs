// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //coleção List
            Console.WriteLine("Hello, World");

            Carro carro1 = new Carro();
            
            Carro carro2 = new Carro();

            Carro carro3 = new Carro();

            Console.WriteLine(carro1.DigaSeuNome("Carro 1"));
            Console.WriteLine(carro2.DigaSeuNome("Carro 2"));
            Console.WriteLine(carro3.DigaSeuNome("Carro 3"));

            Console.Read();




        }

        class Carro
        {
            public string DigaSeuNome(string Nome) 
            {
                return Nome;
            }
        }
    }
}
