using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class Shop
    {
        public Shop(string name, string description, string location, Guid userId)
        {
            Name = name;
            Description = description;
            Location = location;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            UserId = userId;
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

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }


        public virtual List<Product> Product { get; set; } = new List<Product>();
        public virtual User? User { get; set; }
    }
}
