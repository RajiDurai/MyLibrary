using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyLibraryData;
using MyLibraryData.Models;

namespace MyLibraryServices
{
   public class AuthorService : IAuthorService
    {
        private readonly MyLibraryContext _context;

        public AuthorService(MyLibraryContext context)
        {
            _context = context;
        }

        public Author Get(int id)
        {
            return _context.Authors.FirstOrDefault(author => author.Id == id);
        }
        public IEnumerable<Author> GetAllWithBooks()
        {
            return _context.Authors.Include(a => a.Books);
        }

        public Author GetWithBooks(int id)
        {
            return _context.Authors.Where(a => a.Id == id).Include(a => a.Books).FirstOrDefault();
        }
        public string GetAuthor(int id)
        {
            var book = Get(id);
            return book.FName;
        }
    }
}
