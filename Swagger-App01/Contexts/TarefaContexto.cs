using Microsoft.EntityFrameworkCore;
using Swagger_App01.Model;

namespace Swagger_App01.Contexts
{
    public class TarefaContexto : DbContext
    {
        public TarefaContexto(DbContextOptions<TarefaContexto> options) : base(options)
        {
                
        }

        public DbSet<TarefaItem> TarefaItems { get; set; } = null; // liga a classe criada no modelo e liga com o contexto
    }
}
