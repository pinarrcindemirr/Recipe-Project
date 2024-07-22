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
    public class DetailsModel : PageModel
    {
        private readonly RecipeApp_Proje382.Models.RecipeAppContext _context;

        public DetailsModel(RecipeApp_Proje382.Models.RecipeAppContext context)
        {
            _context = context;
        }

      public Models.Recipe Recipe { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            else 
            {
                Recipe = recipe;
            }
            return Page();
        }
    }
}
