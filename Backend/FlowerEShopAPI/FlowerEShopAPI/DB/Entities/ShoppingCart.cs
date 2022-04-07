using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerEShopAPI.DB.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart(string shoppingCartId)
        {
            ShoppingCartId = shoppingCartId;
        }

        [Key]
        public string ShoppingCartId { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
