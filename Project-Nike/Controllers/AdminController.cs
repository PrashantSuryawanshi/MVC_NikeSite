using Microsoft.AspNetCore.Mvc;

namespace Project_Nike.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
    }
}