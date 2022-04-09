using System.ComponentModel.DataAnnotations;

namespace FlowerEShopAPI.DAL.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart(string id)
        {
            Id = id;
        }

        [Key]
        public string Id { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
