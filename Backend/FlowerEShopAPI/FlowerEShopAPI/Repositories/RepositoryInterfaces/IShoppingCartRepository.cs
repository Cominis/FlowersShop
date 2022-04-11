using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Repositories.RepositoryInterfaces
{
    public interface IShoppingCartRepository
    {
        public Task<ShoppingCart> Add(string productId, string userId);
        public Task<string> Delete(string id);
        public Task<List<ShoppingCart>> FindAll(string userId);
        public Task<ShoppingCart> FindById(string id);

    }
}
