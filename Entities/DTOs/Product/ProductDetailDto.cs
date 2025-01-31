﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Product
{
    public class ProductDetailDto
    {
        public Guid ProductId{ get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}
