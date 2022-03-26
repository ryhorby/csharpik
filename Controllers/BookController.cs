using csharpik.Services;
using Microsoft.AspNetCore.Mvc;

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
    }
}
