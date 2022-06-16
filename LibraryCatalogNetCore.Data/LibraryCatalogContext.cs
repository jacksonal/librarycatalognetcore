using System;
using LibraryCatalogNetCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryCatalogNetCore.Data
{

    public class LibraryCatalogDbContext : DbContext, ILibraryCatalogContext
    {
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }

        public string DbPath { get; }

        public LibraryCatalogDbContext()
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
}