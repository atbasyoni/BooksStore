﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BookStore.Core.Models.Helpers;

namespace BookStore.Core.Models.Products.Books
{
    public class Book : BaseEntity
    {
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [MaxLength(13)]
        [RegularExpression(@"^\d{10}(\d{3})?$", ErrorMessage = "Invalid ISBN format.")]
        public string ISBN { get; set; }

        [MaxLength(2)]
        public string Language { get; set; } = null!;

        [Range(1, int.MaxValue, ErrorMessage = "The number of pages must be greater than zero.")]
        public int Pages { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be a non-negative value.")]
        public decimal Price { get; set; }

        public DateTime PublicationDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative value.")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Sold units must be a non-negative value.")]
        public int SoldUnits { get; set; } = 0;

        public int PublisherId { get; set; }

        [JsonIgnore]
        public virtual Publisher Publisher { get; set; } = null!;

        [JsonIgnore]
        public List<BookDiscount> BookDiscounts { get; set; } = null!;

        [JsonIgnore]
        public List<BookAuthor> BookAuthors { get; set; } = null!;

        [JsonIgnore]
        public List<BookGenre> BookGenres { get; set; } = null!;

        [JsonIgnore]
        public List<BookImage> BookImages { get; set; } = null!;
    }
}
