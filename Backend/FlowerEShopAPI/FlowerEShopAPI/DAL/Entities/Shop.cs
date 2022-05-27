using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Shop : BaseEntity
    {
        private ILazyLoader _lazyLoader { get; set; }
        public Shop()
        {

        }

        public Shop(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        public Guid UserId { get; set; }

        private List<Product> _Products;

        public virtual List<Product> Products
        {
            get => _lazyLoader.Load(this, ref _Products);
            set => _Products = value;
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
