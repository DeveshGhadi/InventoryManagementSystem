using System.ComponentModel.DataAnnotations; // 1. Add this namespac
namespace InventoryManagementSystem.Models
{
    public class StockTransaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string TransactionType { get; set; } // In or Out
        public DateTime Date { get; set; }

        public Product Product { get; set; }
    }
}
