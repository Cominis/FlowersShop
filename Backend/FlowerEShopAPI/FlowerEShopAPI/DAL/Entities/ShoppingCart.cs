using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart(string id,string productId,string userId)
        {
            Id = id;
            ProductId = productId;
            UserId = userId;
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [ForeignKey("ProductId")]
        public string ProductId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual List<Product> Product { get; set; }
    }
}
