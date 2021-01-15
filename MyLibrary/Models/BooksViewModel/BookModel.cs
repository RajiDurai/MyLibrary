using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryData.Models;

namespace MyLibrary.Models.BooksViewModel
{
    public class BookModel
    {
       
        public IEnumerable<BookListingModel> Books { get; set; }
    }
}
