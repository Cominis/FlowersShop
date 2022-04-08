using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart(string id)
        {
            Id = id;
        }

        [Key]
        [Column(TypeName = "nvarchar(36)")]
        public string Id { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
