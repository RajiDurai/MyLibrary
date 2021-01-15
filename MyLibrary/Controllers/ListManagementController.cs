using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryData;

namespace MyLibrary.Controllers
{
    public class ListManagementController : Controller
    {
        private readonly IBooksService _bookService;
        private readonly ILocationService _LocationService;
        private readonly INotesService _NotesService;
        public ListManagementController(IBooksService bookService, ILocationService locationService, INotesService notesService)
        {
            _bookService = bookService;
            _LocationService = locationService;
            _NotesService = notesService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNotes(int id, int? notesId)
        {
            var author = _NotesService.GetNotes(id);

            _NotesService.Add(author);

            return RedirectToAction("ListNotes", new { notesId = notesId });
        }

        public IActionResult AddLocation(int id, int? locationId)
        {
            var location = _LocationService.GetLocation(id);

            _LocationService.Add(location);

            return RedirectToAction("ListLocation", new { locationId = locationId });
        }

    }
}
