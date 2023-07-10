// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


string url = "https://localhost:7035/";

Item tarefa1 = new Item();
tarefa1.ID = 1;
tarefa1.Nome = "Pagar a conta";
tarefa1.Finalizado = true;

Item tarefa2 = new Item();
tarefa2.ID = 1;
tarefa2.Nome = "Lavar louças";
tarefa2.Finalizado = false;




Console.WriteLine("Aperte qualquer tecla para finalizar a aplicação!");

Console.Read();
