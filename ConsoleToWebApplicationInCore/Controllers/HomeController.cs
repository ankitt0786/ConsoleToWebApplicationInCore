using Microsoft.AspNetCore.Mvc;
using ConsoleToWebApplicationInCore.Models;
using ConsoleToWebApplicationInCore.Repository;

namespace ConsoleToWebApplicationInCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MetodRepos _db = null;
        public HomeController()
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
            return _db.GetBooksSearch(p1,p2);
        }
    }
}
