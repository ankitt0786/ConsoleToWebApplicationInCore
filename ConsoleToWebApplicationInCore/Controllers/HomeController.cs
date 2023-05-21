using Microsoft.AspNetCore.Mvc;
using ConsoleToWebApplicationInCore.Models;
using ConsoleToWebApplicationInCore.Repository;

namespace ConsoleToWebApplicationInCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
