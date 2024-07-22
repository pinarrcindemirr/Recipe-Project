using System;
using System.Collections.Generic;

namespace RecipeApp_Proje382.Models;

public partial class Rating
{
    public int Id { get; set; }

    public int? ValueRate { get; set; }

    public int? RecipeId { get; set; }

    public string? UserId { get; set; }
}
