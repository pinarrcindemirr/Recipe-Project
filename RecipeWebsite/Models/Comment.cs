﻿using System;
using System.Collections.Generic;

namespace RecipeApp_Proje382.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public int? RecipeId { get; set; }

    public string? UserId { get; set; }
}
