using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibraryData.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required] [Display(Name = "Title")] public string Title { get; set; }       
        [StringLength(17)] [Required] [Display(Name = "ISBN #")] public string ISBN { get; set; }
               
        [Required] [Display(Name = "Checked Out")] public string Checked { get; set; }
        [Required] [Display(Name = "Checked Out to whom")] public string Whom { get; set; }
        [Required] public Location Location { get; set; }
        [Required] public Notes Notes { get; set; }
        [Required] public Genre Genre { get; set; }
        [Required] public Author Author { get; set; }



    }
}
