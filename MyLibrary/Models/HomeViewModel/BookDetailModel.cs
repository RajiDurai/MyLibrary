using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryData.Models;

namespace MyLibrary.Models.HomeViewModel
{
    public class BookDetailModel
    {
       
        public IEnumerable<BookDetailListingModel> Books { get; set; }
    }
}
