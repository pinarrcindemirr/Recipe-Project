using System;
using System.Collections.Generic;

namespace RecipeApp_Proje382.Models;

public partial class Direction
{
    public int Id { get; set; }

    public string? DirectionDescription { get; set; }

    public int? StepNumber { get; set; }

    public int? RecipeId { get; set; }
}
