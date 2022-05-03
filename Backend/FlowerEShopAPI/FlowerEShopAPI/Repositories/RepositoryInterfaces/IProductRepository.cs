using FlowerEShopAPI.DAL.Entities;

namespace FlowerEShopAPI.Repositories.RepositoryInterfaces
{
    public interface IProductRepository
    {
        public Task<Product?> Create(string shopId, string title, string description, string category, string status, decimal price, decimal quantity, string subCategory = "");
        public Task<Product?> Update(string id, string shopId, string title, string description, string category, string status, decimal? price, decimal? quantity, string subCategory = "");
        public Task<string> Delete(string id);
        public Task<Product> FindOne(string id);
        public Task<List<Product>> FindAll(string shopId);
        public Task<List<Product>> FindAll();
    }
}
