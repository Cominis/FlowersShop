using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Product : BaseEntity
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum StatusEnum
        {
            Available,
            OutOfStock
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
        public Guid ShopId { get; set; }

        [ForeignKey("ShopId")]
        public virtual Shop? Shop { get; set; }

        public virtual List<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
    }
}
