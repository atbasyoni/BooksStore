﻿using BookStore.Core.Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStore.Core.Models.Products.Books
{
    public class BookGenre : BaseEntity
    {
        public int GenreId { get; set; }
        [JsonIgnore]
        public virtual Genre Genre { get; set; }

        public int BookId { get; set; }
        [JsonIgnore]
        public virtual Book Book { get; set; }
    }
}
