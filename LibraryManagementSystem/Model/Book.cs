using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Range(1000, 9999)]
        public int PublishedYear { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
