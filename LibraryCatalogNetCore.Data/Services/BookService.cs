using LibraryCatalogNetCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryCatalogNetCore.Data.Services
{
    public class BookService : IBookService
    {
        public IEnumerable<Book> GetBooks()
        {
            var ret = Enumerable.Empty<Book>();
            using(var dbContext = new LibraryCatalogDbContext())
            {
                ret = dbContext.Books.ToArray();
            }
            return ret;
        }
    }
}
