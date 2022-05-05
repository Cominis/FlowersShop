using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.DAL.Repositories.RepositoryInterfaces
{
    public interface IShoppingCartRepository
    {
        public Task<ShoppingCart> Add(string productId, int quantity, string userId);
        public Task<string> Delete(string id);
        public Task<ShoppingCart> FindOne(string id);
        public Task<List<ShoppingCart>> FindAll(string userId);
    }
}
