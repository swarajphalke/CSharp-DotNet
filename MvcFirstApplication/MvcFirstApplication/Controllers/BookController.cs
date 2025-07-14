using Microsoft.AspNetCore.Mvc;
using MvcFirstApplication.Models;

namespace MvcFirstApplication.Controllers
{
    public class BookController : Controller
    {
        // 1. ViewBag Example
        public IActionResult UsingViewBag()
        {
            ViewBag.BookTitle = "The Alchemist";
            ViewBag.BookAuthor = "Paulo Coelho";
            ViewBag.BookPrice = "599/-";
            return View();
        }

        // 2. ViewData Example
        public IActionResult UsingViewData()
        {
            ViewData["BookTitle"] = "Ikigai";
            ViewData["BookAuthor"] = "Francesc Miralles";
            return View();
        }

        // 3. TempData Example
        public IActionResult SetTempData()
        {
            TempData["BookTitle"] = "Atomic Habits";
            TempData["BookAuthor"] = "James Clear";
            return RedirectToAction("UsingTempData");
        }
        public IActionResult UsingTempData()
        {
            return View();
        }


        // 4. Model Example
        public IActionResult UsingModel()
        {
            Book book = new Book
            {
                Id = 1,
                Title = "Rich Dad Poor Dad",
                Author = "Robert Kiyosaki"
            };
            return View(book);

        }
    }
}
