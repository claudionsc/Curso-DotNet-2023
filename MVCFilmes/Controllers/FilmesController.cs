using Microsoft.AspNetCore.Mvc;

namespace MVCFilmes.Controllers
{
    public class FilmesController : Controller
    {
        public string Index() => "Essa é mimha action padrão";
        public string BemVindo(string nome) => $"Olá, seja muito bem vindo {nome}";
    }

}
