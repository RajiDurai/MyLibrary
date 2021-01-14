﻿using MyLibraryData.Models;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryData
{
    public interface IAuthorService
    {
        Author Get(int id);
        IEnumerable<Author> GetAllWithBooks();
        Author GetWithBooks(int id);
    }
}