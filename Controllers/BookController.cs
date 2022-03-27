using csharpik.Models;
using csharpik.Models.BookProject;
using csharpik.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharpik.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService service;

        public BookController(BookService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        public IActionResult Search(string query)
        {
            return View(service.GetAllByQuery(query));
        }

        public IActionResult GetDescription(int id)
        {
            return View(service.GetDescription(id));
        }

        public IActionResult ReadBook(string pass)
        {
            string bookFilePass = service.GetBookPdfPass(pass);
            return PhysicalFile(bookFilePass, "application/pdf");
        }
    }
}
