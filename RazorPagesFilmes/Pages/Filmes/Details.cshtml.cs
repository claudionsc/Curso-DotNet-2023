using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Data;
using RazorPagesFilmes.Models;

namespace RazorPagesFilmes.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesFilmes.Data.RazorPagesFilmesContext _context;

        public DetailsModel(RazorPagesFilmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

      public Filme Filme { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Filmes == null)
            {
                return NotFound();
            }

            var filmes = await _context.Filmes.FirstOrDefaultAsync(m => m.ID == id);
            if (filmes == null)
            {
                return NotFound();
            }
            else 
            {
                Filme = filmes;
            }
            return Page();
        }
    }
}
