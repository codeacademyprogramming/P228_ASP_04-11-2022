﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAdvanced { get; set; }
        public bool IsFeatured { get; set; }

        public List<PricingServices> PricingServices { get; set; }
    }
}
