// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;
using System.Runtime.Versioning;

Console.WriteLine("Hello, World!");


string url = "https://localhost:7244/";
#region "Objetos
Item tarefa1 = new Item();
tarefa1.ID = 1;
tarefa1.Nome = "Pagar a conta";
tarefa1.Finalizado = true;

Item tarefa2 = new Item();
tarefa2.ID = 2;
tarefa2.Nome = "Lavar louças";
tarefa2.Finalizado = false;
#endregion

string endpoint = url + "api/TarefaItems";

// retardar a chamada e esperar a nossa api estar no ar
Thread.Sleep(new TimeSpan(0, 0, 5));

#region "Post e Listar"
//flurl -  Funciona mais ou menos como Axios
// POST
await endpoint.PostJsonAsync(tarefa1);
await endpoint.PostJsonAsync(tarefa2);

// GET
IEnumerable<Item> listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach(Item item in listaTarefas)
{
    var finalizada = item.Finalizado == true ? "finalizada" : "não finalizada";
    Console.WriteLine($"A tarefa {item.Nome} está {finalizada}");
}
#endregion

#region "Alterar e Listar"

// PUT
Console.WriteLine($"ALTERAR. DIGITAR ID ===========");

int id = Convert.ToInt32(Console.ReadLine());
string endpoint_alterar = url + $"api/TarefaItems/{id}";

Item tarefa3 = new Item();
tarefa3.ID = 1;
tarefa3.Nome = "Receber salário";
tarefa3.Finalizado = false;

await endpoint_alterar.PutJsonAsync(tarefa3);

listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();

foreach (Item item in listaTarefas)
{
    var finalizada = item.Finalizado == true ? "finalizada" : "não finalizada";
    Console.WriteLine($"A tarefa {item.Nome} está {finalizada}");
}

#endregion

#region "Deletar e listar"
// DELETE
Console.WriteLine($"DELETAR. INSERIR ID ===========");

string endpoint_deletar = url + $"api/TarefaItems/2";

listaTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>();
foreach (Item item in listaTarefas)
{
    var finalizada = item.Finalizado == true ? "finalizada" : "não finalizada";
    Console.WriteLine($"A tarefa {item.Nome} está {finalizada}");
}
#endregion

Console.WriteLine("Aperte qualquer tecla para finalizar a aplicação!");

Console.Read();
