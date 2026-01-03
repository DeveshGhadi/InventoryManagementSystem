using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace InventoryManagementSystem.Controllers
{
    public class StockController : Controller
    {
        private readonly InventoryContext _context;

        public StockController(InventoryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserId") == null)
                return RedirectToAction("Login", "Auth");

            var products = _context.Products.Include(p => p.Category).ToList();
            return View(products);
        }
        [HttpPost]
        public IActionResult UpdateStock(int productId, int quantity, string type)
        {
            if (HttpContext.Session.GetString("UserId") == null)
                return RedirectToAction("Login", "Auth");

            var product = _context.Products.Find(productId);

            if (type == "In")
            {
                product.Quantity += quantity;
            }
            else if (type == "Out")
            {
                product.Quantity -= quantity;
            }

            var transaction = new StockTransaction
            {
                ProductId = productId,
                Quantity = quantity,
                TransactionType = type,
                Date = DateTime.Now
            };

            _context.Products.Update(product);
            _context.StockTransactions.Add(transaction);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
