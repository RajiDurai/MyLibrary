using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models.HomeViewModel
{
    public class BookDetailListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Whom { get; set; }
    }
}
