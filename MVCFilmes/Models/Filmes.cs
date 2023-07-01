using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime dataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [
            Required(ErrorMessage = "Campo obrigatório"), 
            StringLength(10),
            RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Apenas letras são permitidas")
            ]

        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int? Pontos { get; set; }
    }
}
