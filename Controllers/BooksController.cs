using Microsoft.AspNetCore.Mvc;
using BooksGallery.Services;
using BooksGallery.Models;

namespace BooksGallery.Controllers
{
    public class BooksController : Controller
    {
        private IData _tempdata;
        public BooksController(IData tempdata)
        {
            // dependency injection
            _tempdata = tempdata;
        }

        public IActionResult Index()
        {
            IndexModelView model = new IndexModelView(); // temp class
            model.Books = _tempdata.ReadAll();
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            var book = _tempdata.GetBook(id);
            if(book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
