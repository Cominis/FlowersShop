using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DB.Entities
{
    public class Product
    {
        public Product(string productId, string shopId, string name, string description, decimal price, decimal quantity, DateTime createdAt, DateTime updatedAt)
        {
            ProductId = productId;
            ShopId = shopId;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [Key]
        [Column(TypeName = "nvarchar(36)")]
        public string ProductId { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "decimal(4)")]
        public decimal Quantity { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [Required]
        [ForeignKey("ShopId")]
        public string ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
