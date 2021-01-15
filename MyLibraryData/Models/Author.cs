using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyLibraryData.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }

        public ICollection<Books> Books { get; set; }
    }
}
