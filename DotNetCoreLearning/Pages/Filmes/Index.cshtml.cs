using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetCoreLearning.Models;

namespace DotNetCoreLearning.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly DotNetCoreLearning.Models.DotNetCoreLearningContext _context;

        public IndexModel(DotNetCoreLearning.Models.DotNetCoreLearningContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; }

        public async Task OnGetAsync()
        {
            Filme = await _context.Filme.ToListAsync();
        }
    }
}
