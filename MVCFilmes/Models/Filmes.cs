using System.ComponentModel.DataAnnotations;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime dataLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public decimal Preco { get; set; }
    }
}
