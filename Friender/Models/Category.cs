﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friender.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserCategory> UserCategories { get; set; }

        public List<EventCategory> EventCategories { get; set; }
    }
}
