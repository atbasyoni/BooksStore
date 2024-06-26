﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Helpers
{
    public class Image : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string URL { get; set; } = null!;
        public int Position { get; set; } = 1;
    }
}
