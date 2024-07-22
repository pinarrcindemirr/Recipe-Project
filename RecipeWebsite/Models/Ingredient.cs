using System;
using System.Collections.Generic;

namespace RecipeApp_Proje382.Models;

public partial class Ingredient
{
    public int Id { get; set; }

    public string? IngredientName { get; set; }

    public string? Unit { get; set; }

    public int? Quantity { get; set; }

    public int? RecipeId { get; set; }
}
