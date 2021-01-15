using Microsoft.AspNetCore.Mvc;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;
using MyLibraryData;
using MyLibrary.Models.HomeViewModel;

namespace MyLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBooksService _bookService;
        private readonly IAuthorService _authorService;
        public HomeController(IBooksService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public IActionResult Index()
        {
            var assetModels = _bookService.GetAll();
            var listingResult = assetModels
                .Select(a => new BookDetailListingModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Author = "Raji",
                    Whom = _bookService.GetWhom(a.Id)
                   
                }).ToList();
            var model = new BookDetailModel
            {
                Books = listingResult
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var book = _bookService.Get(id);
            var author = _authorService.Get(id);
            var model = new BookDetailListingModel
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

