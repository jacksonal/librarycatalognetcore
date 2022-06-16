using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryCatalogNetCore.Data {

    public class LibraryCatalogContext : DbContext
    {
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }

        public string DbPath { get; }

        public LibraryCatalogContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "librarycatalog.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Patron
    {
        public int PatronId { get; set; }
        public string Name { get; set; }

        public List<Book> Borrowed { get; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}