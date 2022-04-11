using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Product
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum StatusEnum
        {
            Available,
            OutOfStock
        }

        public Product(Guid shopId, string title, string description, string category, StatusEnum status, decimal price, decimal quantity, string subCategory = "")
        {
            ShopId = shopId;
            Title = title;
            Description = description;
            Category = category;
            SubCategory = subCategory;
            Status = status;
            Price = price;
            Quantity = quantity;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        public string SubCategory { get; set; }

        [Required]
        public StatusEnum Status { get; set; }

        [Required]
        [Precision(4, 2)]
        public decimal Price { get; set; }

        [Required]
        [Precision(6, 0)]
        public decimal Quantity { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [Required]
        [ForeignKey("ShopId")]
        public Guid ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
