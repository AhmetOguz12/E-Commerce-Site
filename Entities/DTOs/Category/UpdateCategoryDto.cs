﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Category
{
    public class UpdateCategoryDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
