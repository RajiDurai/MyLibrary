using Microsoft.AspNetCore.Mvc;
using MyLibraryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Controllers
{
    public class Manage_AuthorsController : Controller
    {
        private readonly IBooksService _bookService;
        private readonly IAuthorService _authorService;
        public Manage_AuthorsController(IBooksService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add (int id, int? authorId)
        {
            var author = _authorService.GetAuthor(id);

            _authorService.Add(author);

            return RedirectToAction("List", new { authorId = authorId });
        }
        public IActionResult Delete(int id, int? authorId)
        {
            var author = _authorService.GetAuthor(id);

            _authorService.Delete(author);

            return RedirectToAction("List", new { authorId = authorId });
        }
    }
}
