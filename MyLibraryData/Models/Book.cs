using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibraryData.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required] [Display(Name = "Title")] public string Title { get; set; }
        [Required] public string Author { get; set; }
        [Required] [Display(Name = "ISBN #")] public string ISBN { get; set; }
        [Required] [Display(Name = "Genre")] public string Genre { get; set; }
        [Required] [Display(Name = "Personal Notes")] public string Notes { get; set; }
        [Required] [Display(Name = "Location#")] public string Location { get; set; }
        [Required] [Display(Name = "Checked Out")] public string Checked { get; set; }
        [Required] [Display(Name = "Checked Out to whom")] public string Whom { get; set; }


    }
}
