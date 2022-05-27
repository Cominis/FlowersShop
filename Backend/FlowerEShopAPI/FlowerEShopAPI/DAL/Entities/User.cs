using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class User : BaseEntity
    {
        private ILazyLoader _lazyLoader { get; set; }
        public User()
        {

        }

        public User(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [JsonIgnore]
        public string Password { get; set; }

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
