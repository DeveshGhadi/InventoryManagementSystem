using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly InventoryContext _context;

        public DashboardController(InventoryContext context)
        {
            _context = context;
        }
        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserId") == null)
                return RedirectToAction("Login", "Auth");

            ViewBag.TotalProducts = _context.Products.Count();
            ViewBag.TotalQuantity = _context.Products.Sum(p => p.Quantity);
            ViewBag.TotalValue = _context.Products.Sum(p => p.Quantity * p.UnitPrice);

            return View();
        }
    }
}
