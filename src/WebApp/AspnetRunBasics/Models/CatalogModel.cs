﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRunBasics.Models
{
    public class CatalogModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string ImageFile { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

    }
}
