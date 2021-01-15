using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models.AuthorsViewModel
{
    public class AuthorBooksListingModel
    {
        public int AuthorId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string ISBN { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Whom { get; set; }
    }
}
