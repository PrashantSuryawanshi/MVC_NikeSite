using Microsoft.AspNetCore.Mvc;
using Project_Nike.Data;
using Project_Nike.Models;
using System.Linq;

namespace Project_Nike.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext context;
        public CustomerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var l = context.Inventry.ToList();
            ViewBag.Products = l;
            return View(l);
        }
        public IActionResult Order()
        {
            return View();
        }
    }
}
