using System;
using System.Collections.Generic;

namespace SholasPie.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}