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
        private readonly IWebHostEnvironment environment;

        public BookService(BookRepository bookRepository, IWebHostEnvironment environment)
        {
            this.bookRepository = bookRepository;
            this.environment = environment;
        }

        public List<Book> GetAllByQuery(string query)
        {
            List<Book> books = new List<Book>();

            books.AddRange(bookRepository.GetAllBookByAuthor(query));
            books.AddRange(bookRepository.GetAllBookByTitle(query));

            List<int> bookIds = new List<int>();
            int quantityOfIteration = books.Count;

            for (int i = 0; i < quantityOfIteration; i++)
            {
                if (bookIds.Contains(books[i].Id))
                    books.Remove(books[i]);
                else
                    bookIds.Add(books[i].Id);
            }

            return books;
        }

        public List<Book> GetAll()
        {
            return bookRepository.GetAll();
        }

        public DescriptionModel GetDescription(int id)
        {
            DescriptionModel descriptionModel = new DescriptionModel();
            descriptionModel.Book = bookRepository.GetBookById(id);
            descriptionModel.BookAuthor = bookRepository.GetAuthorByBookId(id);
            descriptionModel.Keeper = bookRepository.GetBookKeeperByBookId(id);

            return descriptionModel;

        }

        public string GetBookPdfPass(string pass)
        {
            string bookPdfPass = environment.ContentRootPath + pass;

            return bookPdfPass;
        }
    }
}
