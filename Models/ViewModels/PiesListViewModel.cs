﻿using System;
using System.Collections.Generic;

namespace SholasPie.Models.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
