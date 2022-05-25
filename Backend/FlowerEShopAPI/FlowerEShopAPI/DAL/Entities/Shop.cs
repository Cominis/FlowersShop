using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Shop : BaseEntity
    {
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

        public virtual List<Product> Products { get; set; } = new List<Product>();


        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}
