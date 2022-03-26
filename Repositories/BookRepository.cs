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
            try
            {
                List<Book> books = Context.Books.Where(book => book.Title.Contains(title)).ToList();

                return books;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                return new List<Book>();
            }
        }

        public List<Book> GetAllBookByAuthor(string authorName)
        {
            try
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                return new List<Book>();
            }
        }

        public List<Book> GetAll()
        {
            try
            {
                return Context.Books.ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

                return new List<Book>();
            }
        } 

        public Book GetBookById(int id)
        {

            return Context.Books.Single(b => b.Id == id);

        }
    }
}
