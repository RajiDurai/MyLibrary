using System;
using System.Collections.Generic;
using System.Text;
using MyLibraryData.Models;

namespace MyLibraryData
{
    public interface ILocationService
    {
        string GetLocation(int id);
        void Delete(string Location);
        void Add(string Location);
    }
}
