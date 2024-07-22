﻿using System;
using System.Collections.Generic;

namespace RecipeApp_Proje382.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? RecipeDescription { get; set; }

    public string? ImageUrl { get; set; }

    public string? Cuisine { get; set; }

    public int? DifficultyLevel { get; set; }

    public int? PreparationTime { get; set; }

    public int? CookingTime { get; set; }

    public int? Servings { get; set; }

    public string? UserId { get; set; }
}
