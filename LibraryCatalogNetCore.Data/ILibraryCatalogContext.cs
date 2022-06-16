using LibraryCatalogNetCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryCatalogNetCore.Data
{
    public interface ILibraryCatalogContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Patron> Patrons { get; set; }
    }
}