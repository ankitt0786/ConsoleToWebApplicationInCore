using ConsoleToWebApplicationInCore.Models;
using ConsoleToWebApplicationInCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApplicationInCore.Controllers
{
    public class BookController : Controller
    {
        private readonly MetodRepos _db = null;
        public BookController()
        {
            _db = new MetodRepos();
        }

        public List<BookModel> AllBooks()
        {
            return _db.GetBookList();
        }

        public BookModel Singlebook(int id)
        {
            return _db.GetBook(id);
        }

        public List<BookModel> SearchBook(string p1, string p2)
        {
            return _db.GetBooksSearch(p1, p2);
        }
    }
}
