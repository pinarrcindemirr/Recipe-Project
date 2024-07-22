using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeApp_Proje382.Models;

namespace RecipeApp_Proje382.Pages.Recipe
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RecipeApp_Proje382.Models.RecipeAppContext _context;

        public IndexModel(RecipeApp_Proje382.Models.RecipeAppContext context)
        {
            _context = context;
        }

        public IList<Models.Recipe> Recipe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Recipes != null)
            {
                Recipe = await _context.Recipes.ToListAsync();
            }
        }
    }
}
