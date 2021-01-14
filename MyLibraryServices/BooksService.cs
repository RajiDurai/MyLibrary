using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyLibraryData;
using MyLibraryData.Models;

namespace MyLibraryServices
{
    public class BooksService : IBooksService
    {
        private readonly MyLibraryContext _context;

        public BooksService(MyLibraryContext context)
        {
            _context = context;
        }

        public void Add(Books newBook)
        {
            _context.Add(newBook);
            _context.SaveChanges();
        }

        public Books Get(int id)
        {
            return _context.Books.FirstOrDefault(book => book.Id == id);
        }

        public IEnumerable<Books> GetAll()
        {
            return _context.Books;
        }

        public string GetAuthor(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Books> GetByIsbn(string isbn)
        {
            return _context.Books.Where(a => a.ISBN == isbn);
        }

        public string GetTitle(string title)
        {
            throw new NotImplementedException();
        }

        public string GetWhom(int id)
        {
            throw new NotImplementedException();
        }
    }
}
