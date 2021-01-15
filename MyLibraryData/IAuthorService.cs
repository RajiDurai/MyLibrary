using MyLibraryData.Models;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryData
{
    public interface IAuthorService
    {
        Author Get(int id);
        IEnumerable<Author> GetAllWithBooks();
        Author GetWithBooks(int id);
        string GetAuthor(int id);
        void Delete(string author);
        void Add(string author);
    }
}
