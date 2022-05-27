using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShoppingCart : BaseEntity
    {
        private ILazyLoader _lazyLoader { get; set; }
        public ShoppingCart()
        {

        }

        public ShoppingCart(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [Precision(6, 0)]
        public int Quantity;

        [ForeignKey("ProductId")]
        private Product _Product;

        public virtual Product Product
        {
            get => _lazyLoader.Load(this, ref _Product);
            set => _Product = value;
        }

        [ForeignKey("UserId")]
        private User _User;

        public virtual User User
        {
            get => _lazyLoader.Load(this, ref _User);
            set => _User = value;
        }
    }
}
