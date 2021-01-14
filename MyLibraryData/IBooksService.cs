using System.Collections.Generic;
using MyLibraryData.Models;

namespace MyLibraryData
{
    public interface IBooksService
    {
        IEnumerable<Books> GetAll();
        IEnumerable<Books> GetByIsbn(string isbn);
        Books Get(int id);
        void Add(Books newBook);
        string GetAuthor(int id);
        string GetTitle(string title);
        string GetWhom(int id);
        
    }
}
