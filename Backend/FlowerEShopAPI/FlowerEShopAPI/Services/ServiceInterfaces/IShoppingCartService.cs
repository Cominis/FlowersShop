using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Services.ServiceInterfaces
{
    public interface IShoppingCartService
    {
        public Task<ShoppingCart> AddToCart(string productId, int quantity, string userId);
        public Task<string> RemoveFromCart(string id, string userId);
        public Task<List<ShoppingCart>> GetShoppingCart(string userId);
    }
}
