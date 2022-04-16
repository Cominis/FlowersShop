using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.BL.Models
{
    public class Body
    {
        public class ShopBody
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Location { get; set; }
            public Product[] Product { get; set; }
        }

        public class UserCred
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class ShoppingCartBody
        {
            public string ProductId { get; set; }
            public string UserId { get; set; }
            public int Quantity { get; set; }
        }

        public class ProductBody
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string SubCategory { get; set; }
            public string Status { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
            public string ShopId { get; set; }
        }
    }
}
