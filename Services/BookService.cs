using csharpik.Data.BookProjectData;
using csharpik.Models.BookProject;
using csharpik.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace csharpik.Services
{
    public class BookService
    {
        private readonly BookRepository bookRepository;

        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetAllByQuery(string query)
        {
            try
            {
                List<Book> books = new List<Book>();

                books.AddRange(bookRepository.GetAllBookByAuthor(query));
                books.AddRange(bookRepository.GetAllBookByTitle(query));

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
            return bookRepository.GetAll();
        }
    }
}
