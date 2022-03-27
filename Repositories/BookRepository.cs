using csharpik.Data.BookProjectData;
using csharpik.Models.BookProject;
using System.Diagnostics;

namespace csharpik.Repositories
{
    public class BookRepository
    {
        public BookRepository(BookProjectContext context)
        {
            Context = context;
        }

        public BookProjectContext Context { get; }

        public List<Book> GetAllBookByTitle(string title)
        {
            List<Book> books = Context.Books.Where(book => book.Title.Contains(title)).ToList();

            return books;

        }

        public List<Book> GetAllBookByAuthor(string authorName)
        {

            List<Author> authors = Context.Authors.Where(author => author.Name.Contains(authorName)).ToList();
            List<Book> books = new List<Book>();

            if (authors.Count == 0)
                return books;

            foreach (Author author in authors)
            {
                books = Context.Books.Where(book => book.AuthorId == author.Id).ToList();
            }

            return books;
        }

        public List<Book> GetAll()
        {
            return Context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return Context.Books.Single(b => b.Id == id);
        }

        public Author GetAuthorByBookId(int id)
        {
            Book book = Context.Books.Single(b => b.Id == id);

            return Context.Authors.Single(a => a.Id == book.AuthorId);

        }

        public BookNameKeeper GetBookKeeperByBookId(int id)
        {
            return Context.UrlKeepers.Single(a => a.BookId == id);
        }
    }
}
