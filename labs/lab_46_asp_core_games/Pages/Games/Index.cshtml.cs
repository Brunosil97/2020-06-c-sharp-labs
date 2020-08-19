using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_46_asp_core_games.Models;

namespace lab_46_asp_core_games.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly lab_46_asp_core_games.Models.GamesDBContext _context;

        public IndexModel(lab_46_asp_core_games.Models.GamesDBContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Games.ToListAsync();
        }
    }
}
