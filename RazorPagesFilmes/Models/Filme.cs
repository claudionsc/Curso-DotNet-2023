using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Models
{
    public class Filme
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Gênero")]

        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}
