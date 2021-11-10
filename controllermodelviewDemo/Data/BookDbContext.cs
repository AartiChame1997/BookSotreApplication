using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controllermodelviewDemo.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Bookdatabase> Bookdatabases { get; set; }
        internal object Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
