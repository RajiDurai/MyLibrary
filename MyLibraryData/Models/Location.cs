using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLibraryData.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required]
        public string LocationDesc { get; set; }
        public int Count { get; set; }

    }
}
