﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
