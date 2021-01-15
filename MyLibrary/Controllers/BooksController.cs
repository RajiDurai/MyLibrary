using Microsoft.AspNetCore.Mvc;
using MyLibrary.Models.BooksViewModel;
using MyLibraryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _bookService;
        private readonly IAuthorService _authorService;
        public BooksController(IBooksService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public IActionResult Index()
        {
            var assetModels = _bookService.GetAll();
            var listingResult = assetModels
                .Select(a => new BookListingModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Author = "Raji",
                    Whom = _bookService.GetWhom(a.Id)

                }).ToList();
            var model = new BookModel
            {
                Books = listingResult
            };

            return View(model);
        }

        public IActionResult Add(int id)
        {
            var book = _bookService.Get(id);
            var author = _authorService.Get(id);
            var model = new BookListingModel
            {
                Title = book.Title,
                Author = author.FName,
                Whom = book.Whom
            };
            Console.WriteLine(book);
            return View(model);

        }
    }
}
