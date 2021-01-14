using Microsoft.AspNetCore.Mvc;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            return View();
        }

        public IActionResult Detail(int id)
        {
            var book = _bookService.Get(id);
            var author = _authorService.Get(id);
            var model = new BookDetailModel
            { 
                Title = book.Title,
                Author = author.FName,
                Whom = book.Whom
            };
            return View(model);

        }
    }
}

