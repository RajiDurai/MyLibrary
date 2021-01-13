using Microsoft.EntityFrameworkCore;
using System;
using MyLibraryData.Models;

namespace MyLibraryData
{
    public class MyLibraryContext : DbContext
    {
        public MyLibraryContext(DbContextOptions options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
