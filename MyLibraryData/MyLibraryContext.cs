using Microsoft.EntityFrameworkCore;
using System;
using MyLibraryData.Models;

namespace MyLibraryData
{
    public class MyLibraryContext : DbContext
    {
        public MyLibraryContext(DbContextOptions options) : base(options) { }
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Notes> Notes { get; set; }
    }
}
