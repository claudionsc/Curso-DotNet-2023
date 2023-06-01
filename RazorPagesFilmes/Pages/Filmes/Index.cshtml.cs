using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Data;
using RazorPagesFilmes.Models;

namespace RazorPagesFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilmes.Data.RazorPagesFilmesContext _context;

        public IndexModel(RazorPagesFilmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string TermoBusca { get; set; } // o termo que o user vai digitar
        [BindProperty(SupportsGet = true)]
        public string FilmeGenero { get; set; } // genero escolhido
        public SelectList Generos { get; set; } // Lista a ser monatada dos generos
        public async Task OnGetAsync()
        {
            if (_context.Filmes != null)
            {
                var filmes = from m in _context.Filmes
                             select m;
                if (!string.IsNullOrWhiteSpace(TermoBusca))
                {
                    filmes = filmes.Where(f => f.Titulo.Contains(TermoBusca));
                }
                Generos = new SelectList(await _context.Filmes.Select(o => o.Genero).Distinct().ToListAsync());

                Filme = await filmes.ToListAsync();
            }
        }
    }
}
