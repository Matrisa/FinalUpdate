﻿using actiuon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace actiuon.ViewModel
{
    public class ProductCategoryViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<Bids> Bids { get; set; }

    }
}
