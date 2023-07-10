// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Flurl;
using Flurl.Http;
using System.Runtime.Versioning;

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


string endpoint = url + "api/TarefaItems";

// retardar a chamada e esperar a nossa api estar no ar
Thread.Sleep(new TimeSpan(0, 0, 5));


//flurl -  Funciona mais ou menos como Axios
endpoint.PostJsonAsync(tarefa1);
endpoint.PostJsonAsync(tarefa2);

Console.WriteLine("Aperte qualquer tecla para finalizar a aplicação!");

Console.Read();
