using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DB.Entities
{
    public class Shop
    {
        public Shop(string shopId,string name, string description, DateTime createdAt, DateTime updatedAt, string userId)
        {
            ShopId = shopId;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UserId = userId;
        }

        [Key]
        [Column(TypeName = "nvarchar(36)")]
        public string ShopId { get; set; }
        
        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public string UserId { get; set; }
    }
}
