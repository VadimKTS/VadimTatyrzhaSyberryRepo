using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using PasswordGenerator.Services.Interface;
using System.Diagnostics;

namespace PasswordGenerator.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult BookFinder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                ModelState.AddModelError(string.Empty, "Search query is empty.");
                return View("BookFinder");
            }
            var books = await _bookService.SearchBooksAsync(query);
            var resultBooksList = new List<BookViewModel>();
            foreach (var book in books)                 // autoMapper needed
            {
                var bookModel = new BookViewModel() 
                {
                    Author = book.Author,
                    Title = book.Title,
                    PublishedDate = book.PublishedDate,    
                    Picture = book.Picture,
                };
                resultBooksList.Add(bookModel);
            }
            return View("BookFinder", resultBooksList);
        }
                      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}