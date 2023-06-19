using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Models
{
    public class Filme
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Digite o nome do filme")]

        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Gênero")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$]")]
        [Required(ErrorMessage = "Digite o gênero do filme")]
        [StringLength(30, MinimumLength = 2)]

        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }
    }
}
