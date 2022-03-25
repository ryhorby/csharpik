using csharpik.Models.BookProject;
using Microsoft.EntityFrameworkCore;

namespace csharpik.Data.BookProjectData
{
    public class BookProjectContext : DbContext
    {
        public BookProjectContext(DbContextOptions<BookProjectContext> options) 
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<BookUrlKeeper> UrlKeepers { get; set; }
    }
}
