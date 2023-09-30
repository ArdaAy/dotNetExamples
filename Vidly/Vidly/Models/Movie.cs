using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        public string Name { get; set; }

        [Display(Name="Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name="Number In Stock")]
        [Required]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        [Display(Name="Genre")]
        [Required]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

    }
}