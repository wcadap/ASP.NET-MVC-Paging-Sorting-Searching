using System.Data.Entity;
using Paging.Models;

namespace Paging.ContextDb
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books {get; set;}
    }
}