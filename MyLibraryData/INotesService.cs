using System;
using System.Collections.Generic;
using System.Text;
using MyLibraryData.Models;

namespace MyLibraryData
{
    public interface INotesService
    {
        string GetNotes(int id);
        void Add(string author);
    }
}
