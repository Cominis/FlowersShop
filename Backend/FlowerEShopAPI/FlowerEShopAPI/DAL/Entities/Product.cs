using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Product
    {
        public Product(string id, string shopId, string name, string description, decimal price, decimal quantity, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
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
        public string Id { get; set; }

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

        public virtual Shop? Shop { get; set; }
    }
}
