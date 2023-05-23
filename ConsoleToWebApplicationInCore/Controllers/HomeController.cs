using Microsoft.AspNetCore.Mvc;
using ConsoleToWebApplicationInCore.Models;
using ConsoleToWebApplicationInCore.Repository;

namespace ConsoleToWebApplicationInCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var obj = new
            {
                name = "ankit",
                class1 = "1st"
            };
            return View(obj);
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult Contacts() 
        {
            //return View("~/TempView/Index.cshtml");
            return View("../../TempView/Index");
        }
    }
}
