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
            try
            {
                return View(service.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }

        public IActionResult Search(string query)
        {
            return View(service.GetAllByQuery(query));
        }

        public IActionResult GetDescription(int id)
        {
            try
            {
                return View(service.GetDescription(id));
            }
            catch
            {
                return NotFound();
            }
        }

        public IActionResult ReadBook(string pass)
        {
            try
            {
                string bookFilePass = service.GetBookPdfPass(pass);
                
                if (System.IO.File.Exists(bookFilePass))
                {
                    return PhysicalFile($"{bookFilePass}", "application/pdf");
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return NotFound();
            }
        }

        public IActionResult FavoriteBooks()
        {
            return View();
        }
    }
}
