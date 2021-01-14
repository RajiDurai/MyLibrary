using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLibraryData.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string GenreDesc { get; set; }
        public int Count { get; set; }

    }
}
