using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart(Guid productId, Guid userId)
        {
            ProductId = productId;
            UserId = userId;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public virtual List<Product> Product { get; set; }
    }
}
