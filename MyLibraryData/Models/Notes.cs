using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLibraryData.Models
{
    public class Notes
    {
        [Required] public int Id { get; set; }
        
        public string NoteDesc { get; set; }
        public DateTime Time { get; set; }

    }
}
