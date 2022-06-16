using LibraryCatalogNetCore.Data.Entities;
using System.Collections.Generic;

namespace LibraryCatalogNetCore.Data.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
    }
}