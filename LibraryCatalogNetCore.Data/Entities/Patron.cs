using System.Collections.Generic;

namespace LibraryCatalogNetCore.Data.Entities
{
    public class Patron
    {
        public int PatronId { get; set; }
        public string Name { get; set; }

        public List<Book> Borrowed { get; }
    }
}