using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlowerEShopAPI.DAL.Entities
{
    public class User : BaseEntity
    {
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

        public virtual Shop? Shop { get; set; }

        public virtual List<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
    }
}
