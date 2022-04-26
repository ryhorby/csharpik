using csharpik.Data.BookProjectData;
using csharpik.Models.BookProject;

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

        public List<Book> GetAllBookByAuthorName(string authorName)
        {

            Author author = Context.Authors.Single(a => a.Name.Contains(authorName));
            
            if (author == null)
                return new List<Book>();

            author.Books = Context.Books.Where(book => book.Author.Id == author.Id).ToList();

            return author.Books;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = Context.Books.ToList();
            
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = Context.Books.Single(b => b.Id == id);
            return book;
        }

        public Author GetAuthorByBookId(int id)
        {
            Book book = Context.Books.Single(b => b.Id == id);

            book.Author = Context.Authors.Single(a => a.Id == book.AuthorId);

            return book.Author;

        }

        public BookUrlKeeper GetBookKeeperByBookId(int id)
        {
            BookUrlKeeper urlKeeper = Context.UrlKeepers.Single(u => u.BookId == id);
            
            return urlKeeper;
        }
    }
}
