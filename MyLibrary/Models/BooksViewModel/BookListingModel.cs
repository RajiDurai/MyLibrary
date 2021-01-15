using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models.BooksViewModel
{
    public class BookListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Whom { get; set; }
        public string Genre { get; set; }
        public string IsChecked { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }

    }
}
