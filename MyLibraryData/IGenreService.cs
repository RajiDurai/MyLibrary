using System;
using System.Collections.Generic;
using System.Text;
using MyLibraryData.Models;

namespace MyLibraryData
{
    public interface IGenreService
    {
        string GetNotes(int id);
        void Delete(string Genre);
        void Add(string Genre);
    }
}
