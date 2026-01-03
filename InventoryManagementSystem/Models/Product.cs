using System.ComponentModel.DataAnnotations.Schema;
namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }

        public Category Category { get; set; }
    }
}
