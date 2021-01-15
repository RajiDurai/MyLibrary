using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models.ListViewModel
{
    public class LocNotesListingModel
    {
        public int NotesID { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }

        public int LocationId { get; set; }
    }
}
