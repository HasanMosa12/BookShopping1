﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopping1.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }

        [Required]
        [MaxLength(40)]
        public string? AuthorName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Imaget { get; set; }
        [Required]


        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDatail { get; set; }
        public List<CartDetail> CartDetail {  get; set; }

    }
}
