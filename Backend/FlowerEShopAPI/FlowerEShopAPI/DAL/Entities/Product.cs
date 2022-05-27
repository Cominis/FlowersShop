using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Product : BaseEntity
    {
        private ILazyLoader _lazyLoader { get; set; }
        public Product()
        {

        }

        public Product(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

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
        private Shop _Shop;

        public virtual Shop Shop
        {
            get => _lazyLoader.Load(this, ref _Shop);
            set => _Shop = value;
        }

        private List<ShoppingCart> _ShoppingCarts;

        public virtual List<ShoppingCart> ShoppingCarts
        {
            get => _lazyLoader.Load(this, ref _ShoppingCarts);
            set => _ShoppingCarts = value;
        }
    }
}
